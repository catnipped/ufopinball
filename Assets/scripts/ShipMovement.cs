using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
	Rigidbody2D rb;
	float forceX;
	float forceY;
	public float strengthX;
	public float strengthY;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
			
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		forceX = Input.GetAxis ("Horizontal-L");
		forceY = Input.GetAxis ("Vertical-L");
		rb.AddForce (new Vector2 (forceX*strengthX, forceY*strengthY));

	}
}
