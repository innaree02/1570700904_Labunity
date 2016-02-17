using UnityEngine;
using System.Collections;

public class Coll : MonoBehaviour {
	public GameObject NameDesroy;
	public GameObject uicontroller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			Destroy(NameDesroy.gameObject);

			uicontroller.SetActive = true;
		}

	}
}
