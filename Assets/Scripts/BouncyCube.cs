using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyCube : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		GameObject gob;
		
		if (Input.GetMouseButtonDown (0)) {
			gob = GameObject.Find ("BouncyCube");
            
			gob.GetComponent<Rigidbody>().AddForce (transform.forward * 1000);

			gob.GetComponent<Rigidbody>().linearVelocity = new Vector3 (
				Random.Range (0, 10),
				Random.Range (0, 10),
				Random.Range (0, 10));
		}
	}
}

