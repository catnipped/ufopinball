using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShip : MonoBehaviour {
	public GameObject ship;
	public float nearness;
	public float speed;
	Rigidbody2D rb;
	float shipAngle;
	Vector2 shipPos;
	Vector2 shipDirection;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		shipPos = ship.transform.position;
		if (Vector2.Distance (shipPos, this.transform.position) < nearness) {
			//shipAngle = Vector2.Angle (this.transform.position, shipPos);
			float dy = transform.position.y - shipPos.y;
			float dx = transform.position.x - shipPos.x;
			shipAngle = Mathf.Atan2 (dy, dx);
			shipDirection.x = -Mathf.Cos(shipAngle)*speed; 
			shipDirection.y = -Mathf.Sin(shipAngle)*speed;
			rb.AddForce (shipDirection);
		}
		
	}
}
