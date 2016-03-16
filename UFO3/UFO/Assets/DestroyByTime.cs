using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {
	public float liftTime; 
	// Use this for initialization
	void Start () {
		Destroy (gameObject, liftTime);
	}
	

}
