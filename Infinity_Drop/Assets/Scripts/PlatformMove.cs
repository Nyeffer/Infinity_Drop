using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

	// Public Variables
	public bool NorS; // A boolean that dictates whether the Platform goes North or South
	public bool EorW; // A Boolean that dictates whether the Platform goes East or West
	public bool VorH; // A Boolean that dictates whether move in Y or X axis
	public bool isLinear; // A Bool that dictates whether the Platform goes in a singular direction or not
	public float speed = 1; // Multiplier for how fast the platform move

	public GameObject Parent; // Object that Player will become a child of

	// Private Variables

	private Vector3 pos; // Vector3 that record the gameObject's position


	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position; // Initializing Vector3 pos
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 npos = pos;
		if(isLinear) { // is Linear?
			if(NorS) { // if yes, North or South?
				if(EorW) { // North and East
					// positive Z and X
					npos = new Vector3(pos.x + (speed * Time.deltaTime), pos.y, pos.z + (speed * Time.deltaTime));	
				} else { // North and West
					// positive Z and negative X
					npos = new Vector3(pos.x - (speed * Time.deltaTime), pos.y, pos.z + (speed * Time.deltaTime));
				}
			} else {
				if(EorW) { // South and East
					// negative Z and positive X
					npos = new Vector3(pos.x + (speed * Time.deltaTime), pos.y, pos.z - (speed * Time.deltaTime));	
				} else { // South and West
					// negative Z and X
					npos = new Vector3(pos.x - (speed * Time.deltaTime), pos.y, pos.z  - (speed * Time.deltaTime));
				}
			}
		} else { // if no, Move in Z or X axis
			if(VorH) { // Vertical, use Z axis
				if(NorS) { // North
					npos = new Vector3(pos.x, pos.y, pos.z + (speed * Time.deltaTime));	
				} else { // South
					npos = new Vector3(pos.x, pos.y, pos.z - (speed * Time.deltaTime));
				}
			} else { // Horizontal, use X axis
				if(EorW) { // East
					npos = new Vector3(pos.x + (speed * Time.deltaTime),pos.y, pos.z);	
				} else { // West
					npos = new Vector3(pos.x - (speed * Time.deltaTime),pos.y, pos.z);
				}
			}
		}
		pos = npos;
		gameObject.transform.position = pos;
	}

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
