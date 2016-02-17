using UnityEngine;
using System.Collections;

public class UIGAME : MonoBehaviour {
	public bool allOptions = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		allOptions = GUI.enabled;
	}
}
