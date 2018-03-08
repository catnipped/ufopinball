using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject followThis;
	Vector2 followVector;
	Vector2 cameraVector;
	public float lerpFactor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		cameraVector = this.transform.position;
		followVector = followThis.transform.position;
		this.transform.position = new Vector3 (Mathf.Lerp (cameraVector.x, followVector.x-1f, lerpFactor*Time.deltaTime), Mathf.Lerp (cameraVector.y, followVector.y-1f, lerpFactor*Time.deltaTime), -10f);
	
	}
}
