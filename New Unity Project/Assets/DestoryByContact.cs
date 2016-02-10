using UnityEngine;
using System.Collections;

public class DestoryByContact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Boundary")
		{
			return;
		}
		else
			Destroy(other.gameObject);
		Destroy(gameObject);﻿
	}
}