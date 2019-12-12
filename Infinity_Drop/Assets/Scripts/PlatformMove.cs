using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player") {
            Debug.Log("StepOn");
            col.gameObject.transform.parent = transform;
        }
    }

    void OnTriggerExit(Collider col) {
        if(col.gameObject.tag == "Player") {
            Debug.Log("StepOff");
			col.gameObject.transform.parent = null;
        }
    }
}
