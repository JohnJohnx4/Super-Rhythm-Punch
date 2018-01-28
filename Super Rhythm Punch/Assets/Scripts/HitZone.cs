using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitZone : MonoBehaviour {
	public GameObject player;
	Animator otherAnimator;

 	void Awake () {
    	otherAnimator = player.GetComponent<Animator>();
 	}

	void OnTriggerStay(Collider other) {
        if (Input.GetButtonDown("Jump")) {
			print("Hit!");
			otherAnimator.SetTrigger("testPunch");
			
			// play hit animation
			Destroy(other.gameObject);
			//create screenshake
		}
    }
}
