using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRing : MonoBehaviour {
	Material color;
	float angle;
	float relativeX;
	float relativeY;
	Vector2 inputPos;
	float inputAngle;

	// Use this for initialization
	void Start () {
		color = GetComponent<Renderer>().material; 
		relativeX = this.transform.localPosition.x ;
		relativeY = this.transform.localPosition.y ;
		angle = Mathf.Atan2(relativeX,relativeY) * Mathf.Rad2Deg;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Mathf.Abs (Input.GetAxis ("Horizontal-L") + Input.GetAxis ("Vertical-L")) > 0.4f) {

			inputPos = new Vector2 (Input.GetAxis ("Horizontal-L"), Input.GetAxis ("Vertical-L"));
			inputAngle = Mathf.Atan2 (inputPos.x, inputPos.y) * Mathf.Rad2Deg;

			if (inputAngle > angle - 20 && inputAngle < angle + 20) {
				color.color = new Color (255f, 255f, 255f);
			} else {
				color.color = new Color (0f, 0f, 0f);
			}
		} else {
			color.color = new Color (0f, 0f, 0f);
		}

	}
}
