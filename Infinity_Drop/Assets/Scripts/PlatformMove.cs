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

	// Private Variables

	private Vector3 pos; // Vector3 that record the gameObject's position


	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 npos = Vector3.zero;
		if(isLinear) { // is Linear?
			if(NorS) { // if yes, North or South?
				if(EorW) { // North and East
					// positive Y and X
					npos = new Vector3(pos.x + (speed * Time.deltaTime),pos.y + (speed * Time.deltaTime), pos.z);	
				} else { // North and West
					// positive Y and negative X
					npos = new Vector3(pos.x - (speed * Time.deltaTime),pos.y + (speed * Time.deltaTime), pos.z);
				}
			} else {
				if(EorW) { // South and East
					// negative Y and positive X
					npos = new Vector3(pos.x + (speed * Time.deltaTime),pos.y - (speed * Time.deltaTime), pos.z);	
				} else { // South and West
					// negative Y and X
					npos = new Vector3(pos.x - (speed * Time.deltaTime),pos.y - (speed * Time.deltaTime), pos.z);
				}
			}
		} else { // if no, Move in Y or X axis
			if(VorH) { // Vertical, use  axis
				if(NorS) { // North
					npos = new Vector3(pos.x, pos.y + (speed * Time.deltaTime), pos.z);	
				} else { // South
					npos = new Vector3(pos.x, pos.y - (speed * Time.deltaTime), pos.z);
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
	}
}
