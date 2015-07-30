using UnityEngine;
using System.Collections;

public class SkynautController : MonoBehaviour, Controlable {
	public float m_Speed=10;
	public float m_MaxSpeed=5;

	Controller m_input;
	// Use this for initialization
	void Start (Controller controls) {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SubmitAction(int action);

	void MoveNorth ();
	
	void MoveSouth ();
	
	void MoveEast ();
	
	void MoveWest ();
	
	void Pickup ();
	
	void UseWorld ();
	
	void UseEquipped ();
	
	void UseItem ();
	
	void Idle();
	
	void Face();
	
	bool IsMoving();
	
	int GetFacing();
}
