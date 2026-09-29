using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

    //destory anything that the bullet hits apart from Player and Ground
	
	void  OnCollisionEnter (Collision col) {
		if (col.gameObject.tag != "Player" & col.gameObject.tag != "Terrain") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
	}
	
}
