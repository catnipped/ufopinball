using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEyes : MonoBehaviour {
	public float width;
	public float height;
	public float speed;
	Vector2 center;
	Vector2 velocity;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		center = this.transform.localPosition;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb = this.GetComponentInParent<Rigidbody2D>();
		velocity = new Vector2(rb.velocity.x / 3, rb.velocity.y / 3);
		velocity.x = Mathf.Clamp (rb.velocity.x, -1f, 1f) * width ;
		velocity.y = Mathf.Clamp (rb.velocity.y, -1f,1f) * height ;
		this.transform.localPosition = Vector2.Lerp (this.transform.localPosition, center+velocity, speed);
	}
}
