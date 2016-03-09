using UnityEngine;
using System.Collections;

public class DestoryByPlayer : MonoBehaviour {
	public GameObject explosion;
	public GameObject PlayerExlosion; 

	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Destory Bloat")   //ถ้าชนกับวัตถุที่เป็นขอบเขต จะส่งค่า return เป็นค่าธรรมดา
		{
			return ;
		}
		if(other.tag == "Player")
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
			Instantiate(explosion, transform.position,transform.rotation); //สร้าง VFX ในการชนตรงุกาบาศ
			Instantiate(PlayerExlosion,other.transform.position,other.transform.rotation); //สร้าง VFX ในการชนตรงอยานผู้เล่น 

		}
		//ถ้า ชนกับกระสุน 
		if(other.tag == "Bloat")
		{	
				Destroy(other.gameObject);    //ลบตัวที่มาชน
				Destroy(gameObject);				//ลบตัวเองทิ้ง 
				Instantiate(explosion,transform.position,transform.rotation);  //สร้าง VFX ในการชนตรงอุกาบาศ
		}

	}
}
