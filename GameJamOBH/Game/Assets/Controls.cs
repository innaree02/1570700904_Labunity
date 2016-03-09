using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;
	public Vector3 game;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if(Input.GetButtonDown("Fire1"))
			rb.AddForce(transform.up * thrust);
	}
}
