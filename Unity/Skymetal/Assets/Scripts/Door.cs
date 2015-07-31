using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public bool open;
	protected BoxCollider2D collider;
	// Use this for initialization
	void Start () {
		open = false;
		collider = GetComponent<BoxCollider2D> ();
	}

	void Use()
	{
		open = !open;
		collider.enabled = !open;
		AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
		audio.Play();
		GetComponent<Animator>().SetBool("open", open);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
