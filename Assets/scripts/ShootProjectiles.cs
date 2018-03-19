using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectiles : MonoBehaviour {
	Vector2 inputPos;
	Vector2 localPos;
	float inputAngle;
	public GameObject projectileObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Mathf.Abs (Input.GetAxis ("Horizontal-R") + Input.GetAxis ("Vertical-R")) > 0.4f) {

			inputPos = new Vector2 (Input.GetAxis ("Horizontal-R"), Input.GetAxis ("Vertical-R"));
			inputAngle = Mathf.Atan2 (inputPos.x, inputPos.y);
			localPos = new Vector2 (this.transform.position.x + Mathf.Cos(-inputAngle + Mathf.PI * 0.5f) * 0.5f, this.transform.position.y + Mathf.Sin(-inputAngle + Mathf.PI * 0.5f) * 0.5f);
			var projectile = Instantiate (projectileObject, localPos, Quaternion.identity);
//			projectile.transform.Rotate(new Vector3(0,0,-inputAngle * Mathf.Rad2Deg));
		}
	}
}
