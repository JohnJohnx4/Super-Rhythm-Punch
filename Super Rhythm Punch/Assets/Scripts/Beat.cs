using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
     	rb.velocity = new Vector3(speed, 0, speed);
	}

	void OnTriggerEnter(Collider other) {
        Destroy(this.gameObject);
    }

}