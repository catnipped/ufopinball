using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrail : MonoBehaviour {
	
	Vector2 velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var parentScript = this.GetComponentInParent<Projectile>();
		velocity = parentScript.direction * 5;
		this.transform.localPosition = velocity;
	}
}
