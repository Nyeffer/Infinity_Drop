using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour {

	// Public Variables
	public GameObject player; // tracks the Player's Y position multipled by -1
	public float feetCounted = 0; // access for UI 
	public Vector3 startPos; // Get the starting position of Player

	// Use this for initialization
	void Start () {
		startPos = player.transform.position;
		feetCounted = (player.transform.position.y - (int)startPos.y) * -1;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
