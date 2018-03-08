using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipJoystick : MonoBehaviour {
	public string joyStickH;
	public string joyStickV;
	public float width;
	public float height;
	public float speed;
	Vector2 center;
	Vector2 joyPos;
	// Use this for initialization
	void Start () {
		center = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		joyPos = new Vector2( Input.GetAxis(joyStickH)*width, Input.GetAxis(joyStickV)*height);
		this.transform.localPosition = Vector2.Lerp (this.transform.localPosition, center+joyPos, speed);
	}
}
