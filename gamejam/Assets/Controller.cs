using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public float speed;
	public Rigidbody rb;
	public Vector3 gmae;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1"))
		{
			rb.AddForce(transform.up * speed);

		}

	
	}
}
