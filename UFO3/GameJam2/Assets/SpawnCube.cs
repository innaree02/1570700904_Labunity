using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {
	public GameObject newCube; 
	public GameObject newposition; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Instantiate (newCube, newposition.transform.position.x, newposition.transform.position.y, newposition.transform.position.z);
	
	}
}
