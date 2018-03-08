using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour {
	public float restSpeed;
	public float activeSpeed;
	HingeJoint2D hinge;
	JointMotor2D motor;
	public string inputName;

	// Use this for initialization
	void Start () {
		hinge = GetComponent<HingeJoint2D> ();
		motor = hinge.motor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis (inputName) == 1) {
			Debug.Log ("button is pressed");
			motor.motorSpeed = activeSpeed;

		} else {
			motor.motorSpeed = restSpeed;
		}	

		hinge.motor = motor;

			
	}
}
