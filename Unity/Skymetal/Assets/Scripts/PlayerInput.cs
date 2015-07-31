using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			gameObject.SendMessage ("East");
		} else if (Input.GetKey ("left")) {
			gameObject.SendMessage ("West");
		} else if (Input.GetKey ("up")) {
			gameObject.SendMessage ("North");
		} else if (Input.GetKey ("down")) {
			gameObject.SendMessage ("South");
		} else {
			gameObject.SendMessage ("Idle");
		}
	}
}
