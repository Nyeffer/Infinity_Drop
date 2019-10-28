using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	private void OnTriggerEnter(Collider col) { // Whenever a trigger enter this objects range/trigger
		if(col.gameObject.tag == "Floor") { // Check if gameObject is a "Floor"
			Destroy(col.gameObject);  // Destroy Floor
		}
	}
}
