using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour {
public GameObject note;
public Transform beatSpawn;
public float startDelay = 1.0f;
public float speed = 1.0f;
public float mult = 0.6f;

	void Start() {
		beatInvoker();
	}

	void beatSpawner() {
        Instantiate(note, beatSpawn.position, beatSpawn.rotation);
	}

	void beatInvoker () {
		float spawnSpeed = mult * speed;
		InvokeRepeating("beatSpawner", startDelay, spawnSpeed);
	}
}