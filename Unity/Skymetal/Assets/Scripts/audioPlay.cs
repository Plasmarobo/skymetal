using UnityEngine;
using System.Collections;
public class audioPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audio = gameObject.GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
