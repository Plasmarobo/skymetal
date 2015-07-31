using UnityEngine;
using System.Collections;

public class SquareWalk : MonoBehaviour {
	public float change;
	// Use this for initialization
	void Setup()
	{
		change = 0;
	}
	
	// Update is called once per frame
	void Update () {
		var delta = change - Time.timeSinceLevelLoad;
		if (delta <= 0) {
			change = Time.timeSinceLevelLoad + 4;
		} else if (delta > 3) {
			gameObject.SendMessage("East");
		} else if (delta > 2) {
			gameObject.SendMessage("South");
		} else if (delta > 1) {
			gameObject.SendMessage("West");
		} else {
			gameObject.SendMessage("North");
		}
	}
}
