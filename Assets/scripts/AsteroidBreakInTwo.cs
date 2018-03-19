using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBreakInTwo : MonoBehaviour {
	public GameObject part;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy() {
		var fragment = Instantiate (part, this.transform.localPosition, Quaternion.identity);
		var fragment2 = Instantiate (part, this.transform.localPosition, Quaternion.identity);
		fragment2.transform.Rotate (0f, 0f, 180f);
	}

}
