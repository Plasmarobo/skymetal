using UnityEngine;
using System.Collections;

public class OnHit : MonoBehaviour {
	public string message = "";
	public float life = 0.2f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] intersects = GameObject.FindGameObjectsWithTag("Usable");
		foreach(GameObject other in intersects)
		{
			other.SendMessageUpwards(message);
		}
		Object.Destroy (gameObject, life);
	}

}
