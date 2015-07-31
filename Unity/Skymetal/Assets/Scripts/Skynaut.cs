using UnityEngine;

public class Skynaut : MonoBehaviour {
	public float m_impulse = 50;
	//public float m_acceleration = 10;
	public float m_maxSpeed = 50;
	public bool m_moving = false;
	public int m_facing;
	Animator m_animator;
	Rigidbody2D m_body;

	void Start()
	{
		m_animator = GetComponent<Animator>();
		m_body = GetComponent<Rigidbody2D> ();
		m_facing = Definitions.South;
	}

	void East()
	{
		m_moving = true;
		var velocityX = System.Math.Abs (m_body.velocity.x);
		if (m_body.velocity.x < 5) {
			m_body.AddForce (new Vector2 (1, 0) * m_impulse);
		}
		if (velocityX > m_maxSpeed) {
			m_body.velocity = new Vector2(m_maxSpeed, m_body.velocity.y);
		}
		m_facing = Definitions.East;
	}
	void West()
	{
		m_moving = true;
		var velocityX = System.Math.Abs (m_body.velocity.x);
		if (m_body.velocity.x > -5) {
			m_body.AddForce (new Vector2 (-1, 0) * m_impulse);
		}
		if (velocityX > m_maxSpeed) {
			m_body.velocity = new Vector2(-m_maxSpeed, m_body.velocity.y);
		}
		m_facing = Definitions.West;
	}
	void North()
	{
		m_moving = true;
		var velocityY = System.Math.Abs (m_body.velocity.y);
		if (m_body.velocity.y < 5) {
			m_body.AddForce (new Vector2 (0, 1) * m_impulse);
		}
		if (velocityY > m_maxSpeed) {
			m_body.velocity = new Vector2(m_body.velocity.x, m_maxSpeed);
		}
		m_facing = Definitions.North;
	}
	void South()
	{
		m_moving = true;
		var velocityY = System.Math.Abs (m_body.velocity.y);
		if (m_body.velocity.y > -5) {
			m_body.AddForce (new Vector2 (0, -1) * m_impulse);
		}
		if (velocityY > m_maxSpeed) {
			m_body.velocity = new Vector2(m_body.velocity.x, -m_maxSpeed);
		}
		m_facing = Definitions.South;
	}
	void Use()
	{
		m_animator.SetTrigger ("use");
		Vector3 pos = new Vector3 (0, 0, 0);
		switch (m_facing) {
		case Definitions.North:
			pos.x = gameObject.transform.position.x;
			pos.y = gameObject.transform.position.y + 1;
			break;
		case Definitions.East:
			pos.x = gameObject.transform.position.x + 1;
			pos.y = gameObject.transform.position.y;
			break;
		case Definitions.South:
			pos.x = gameObject.transform.position.x;
			pos.y = gameObject.transform.position.y - 1;
			break;
		case Definitions.West:
			pos.x = gameObject.transform.position.x - 1;
			pos.y = gameObject.transform.position.y;
			break;
		default:
			break;
		}
		var prefab = Resources.Load<GameObject> ("Hitbox");
		GameObject hitbox = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
		hitbox.GetComponent<OnHit> ().message = "Use";
		hitbox.GetComponent<OnHit> ().life = 0;

	}
	void Idle()
	{
		m_moving = false;
	}
	// Update is called once per frame
	void Update () {
		m_animator.SetInteger ("direction", m_facing);
		if (System.Math.Abs (m_body.velocity.x) + System.Math.Abs (m_body.velocity.y) > 0.5) {
			m_moving = true;
		}
		m_animator.SetBool("moving", m_moving);
	}
}
