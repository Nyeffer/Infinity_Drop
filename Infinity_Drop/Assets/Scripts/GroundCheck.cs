using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	private bool isGrounded = false;
	public GameObject player;
	void Update() {
		
	}
	void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

	void OnTriggerStay(Collider col) {
		if(col.gameObject.tag == "Ground") {
			isGrounded = true;
		}
	}

	void OnTriggerExit(Collider col) {
        if(col.gameObject.tag == "Ground") {
            isGrounded = false;
			player.GetComponent<Animator>().SetBool("isJump", false);
        }
    }

	public bool GetisGround() {
		return isGrounded;
	}
}
