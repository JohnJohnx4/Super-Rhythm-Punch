using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionNoteSpawner : MonoBehaviour {
public GameObject note;
public Transform noteSpawn;

	void Start() {
		//InvokeRepeating("noteSpawner", 1.0f, 1.0f);
	}

	void Update () {
		if (Input.GetButtonDown("Fire3")) {
			Instantiate(note, noteSpawn.position, noteSpawn.rotation);
		}
		
	}

	void noteSpawner() {
            Instantiate(note, noteSpawn.position, noteSpawn.rotation);
	}
}
