using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLights : MonoBehaviour {
	public GameObject light;
	Vector2 position;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 12; i++) {
			position = new Vector2(this.transform.position.x,this.transform.position.y+0.217f);
			var child = Instantiate (light, position, Quaternion.identity);
			child.transform.RotateAround (new Vector2(this.transform.position.x,this.transform.position.y), Vector3.forward, 30f * i);
			child.transform.SetParent (this.transform);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
