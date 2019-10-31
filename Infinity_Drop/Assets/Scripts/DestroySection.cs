using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySection : MonoBehaviour {

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
