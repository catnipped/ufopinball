using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float force;
	Vector2 direction;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
		direction = new Vector2 (Input.GetAxis("Horizontal")*force,Input.GetAxis("Vertical")*force);

	}
	
	// Update is called once per frame

	void OnCollisionEnter2D (Collision2D col)
	{	
		Debug.Log (col.gameObject);
		if(col.gameObject.tag != "player")
		{
			Destroy(this.gameObject);
		}
	}

	void Update () {
		
		this.transform.Translate (direction, Space.World);
	}

}
