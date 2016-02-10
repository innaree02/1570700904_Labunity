using UnityEngine;
using System.Collections;

public class Randomrotator : MonoBehaviour {
	public float tumble;


	// Use this for initialization
	void Start () {
		Rigidbody rb;
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;

	}
	
	// Update is called once per frame
	void Update () {

	}
}
