using UnityEngine;
using System.Collections;

public class Tile {
	public Transform prefab;
	public int oxygen;
	public int heat; 
	public int power;
}

public class Section {
	public ArrayList tiles;
	public ArrayList links;

	public int power;
	public int heat;
	public int oxygen;

	void Update()
	{
	}
}

public class Map : MonoBehaviour {
	public int w;
	public int h;
	public int seed;
	public Transform[,] map;
	public float tileWidth;


	void Awake()
	{
		Random.seed = seed;
		GenerateMap ();
	}
	
	void GenerateMap()
	{
		map = new Transform[w, h];

		for(int j = 0; j < h; ++j)
		{
			for(int i = 0; i < w; ++i)
			{
				Transform tilePrefab;

				if ((j == 0) && (i == 8))
				{
					tilePrefab = LookupTile ("RedDoor");
				}
				else if ((i == 0) || (i == (w-1)) || (j == 0) || (j == (h-1)))
				{
					tilePrefab = LookupTile("Barrier");
				}
				else
				{
					tilePrefab = LookupTile ("MetalFloor");
				}

				Transform tile = Instantiate(tilePrefab, new Vector3(transform.position.x + i, transform.position.y + j, 1), Quaternion.identity) as Transform;
				tile.parent = transform;
				map[i,j] = tile;
			}
		}
	}

	public Transform GetTileAt(int x, int y)
	{
		if (x < 0 || y < 0 || x > w || y > h)
		{
			Debug.LogWarning ("X or Y coordinate is out of bounds!");
			return null;
		}
		return map[x, y];
	}

	protected Transform LookupTile(string name)
	{
		Transform prefab = Resources.Load <Transform> ("Tiles/" +name);
		if (!prefab) {
			Debug.LogWarning ("Unable to find " + name + " in your Resources folder.");
		}
		return prefab;
	}

	void Update()
	{
	}

}
