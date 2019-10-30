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
	private Text text; // Text Component

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>(); // Initialize the Text Component
		startPos = player.transform.position; // Get the player's Starting position
		feetCounted = (player.transform.position.y - (int)startPos.y) * -1; // Set the initial amount of points
	}
	
	// Update is called once per frame
	void Update () {
		feetCounted = (player.transform.position.y - (int)startPos.y) * -1; // Update the points while going down
		int feet = (int)feetCounted; // Convert to an integer
		text.text = " " + feet.ToString() + " ft"; // Show the points to the player.
	}

	// Getter 
	public float GetFeetCount() { // a function to get the current point of the Player
		return feetCounted;
	}
}
