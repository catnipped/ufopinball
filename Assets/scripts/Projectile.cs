using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float force;
	public Vector2 direction;
	public GameObject player;
	float life;
	// Use this for initialization
	void Start () {
		life = 30f;
		this.transform.Rotate (0f, 0f, 45f);
		direction = new Vector2 (Input.GetAxis("Horizontal-R")*force,Input.GetAxis("Vertical-R")*force);

	}
	
	// Update is called once per frame

	void OnTriggerEnter2D (Collider2D other)
	{	
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "asteroid") {
			Destroy (other.gameObject);
		}
		if(other.gameObject.tag != "player")
		{
			Destroy(this.gameObject);
		}
	}

	void Update () {
		life -= Time.deltaTime;
		if (life < 0) {
			Destroy (this.gameObject);
		}
			
		this.transform.Translate (direction, Space.World);
	}

}
