using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour {
	GameObject ship;
	public GameObject laserObject;
	public float nearness;
	Vector2 eye;
	float angle;
	LineRenderer line;

	// Use this for initialization
	void Start () {
		var followShip = GetComponent<FollowShip> ();
		ship = followShip.ship;
		line = this.GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		eye = transform.GetChild (0).position;
		if (Vector2.Distance (ship.transform.position, this.transform.position) < nearness) {
			Debug.Log ("pew!");
			line.enabled = true;
			line.SetPosition (0, eye);
			line.SetPosition (1, ship.transform.position);
			line.sortingOrder = 5;
		} else {
			line.enabled = false;
		}
	}
		

}
