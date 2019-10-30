using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {

	// Public Variables
	public GameObject player; // tracks the Player's Y position multipled by -1
	

	// Private Variables
	private float feetCounted = 0; // access for UI 
	private Vector3 startPos; // Get the starting position of Player
	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		startPos = player.transform.position;
		feetCounted = (player.transform.position.y - (int)startPos.y) * -1;
	}
	
	// Update is called once per frame
	void Update () {
		feetCounted = (player.transform.position.y - (int)startPos.y) * -1;
		text.text = " " + feetCounted.ToString() + " ft"; 
	}

	// Getter 
	public float GetFeetCount() {
		return feetCounted;
	}
}
