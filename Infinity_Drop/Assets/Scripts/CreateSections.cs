﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSections : MonoBehaviour {

	// Public Variables
	public GameObject[] Sections; // An array of prefabs/Section that will be chosen randomly
	public int offset = 0; // an integer of the distant between the player and the position of the section.

	private void SpawnSection(int pos) { // Function that will spawn a Section
		Vector3 spawnLoc= new Vector3(gameObject.transform.position.x, pos, gameObject.transform.position.z); 
		Instantiate(Sections[0], spawnLoc, Quaternion.identity);
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			SpawnSection((int)col.gameObject.transform.position.y - (60/2));
		}
	}

	
}
