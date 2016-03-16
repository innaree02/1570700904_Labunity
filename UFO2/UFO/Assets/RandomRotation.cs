using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {
	public float tumble;
	// Use this for initialization
	void Start () {
		//  angularVelocity คือ การทำการหมุนของวัตถุ Random.insideUnitSphere คือ การสุ่มให้เป็นทรงกลม คูณกับ เเรงหมุน 
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere *tumble ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
