﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSections : MonoBehaviour {

	// Public Variables
	public GameObject[] Sections; // An array of prefabs/Section that will be chosen randomly.
	public int offset = 0; // an integer of the distant between the player and the position of the section.

	private void SpawnSection(int pos) { // Function that will spawn a Section
		int rand = Random.Range(0, Sections.Length); // Make a number between 0 and the Length of the Array.
		Vector3 spawnLoc= new Vector3(gameObject.transform.position.x, pos, gameObject.transform.position.z); 
		Instantiate(Sections[rand], spawnLoc, Quaternion.identity);
	}

	void OnTriggerEnter(Collider col) { // Whenever player Enters, Create a new Section.
		if(col.gameObject.tag == "Player") { // Check object if it's Player
			SpawnSection((int)col.gameObject.transform.position.y - offset); // Create the Section
		}
	}

	
}
