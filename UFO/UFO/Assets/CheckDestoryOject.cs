using UnityEngine;
using System.Collections;

public class CheckDestoryOject : MonoBehaviour {
	//อะไรก็ตามที่ออกจากกรอบ จะลบทิ้ง
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}