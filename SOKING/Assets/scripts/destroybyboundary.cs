using UnityEngine;
using System.Collections;

public class destroybyboundary : MonoBehaviour {
	void Start(){
		
		
	}
	void Update(){
	}
	void OnTriggerExit(Collider other){
		Destroy (other.gameObject);
	}
}