using UnityEngine;
using System.Collections;

public class DestoryByPlayer : MonoBehaviour {
	public GameObject explosion;
	public GameObject PlayerExlosion; 
	private GameController gameController;
	public int scoreValue;


	void Start () {
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");

			if(gameControllerObject != null)
			{
			gameController = gameControllerObject.GetComponent<GameController>();
			}

			if(gameControllerObject == null)
			{
				Debug.Log("Cannot find 'GameController' script");
			}
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
			gameController.GameOver();

		}
		//ถ้า ชนกับกระสุน 
		if(other.tag == "Bloat")
		{	
				
			gameController.AddScore (scoreValue);
				Destroy(other.gameObject);    //ลบตัวที่มาชน
				Destroy (gameObject);
								//ลบตัวเองทิ้ง 
				
				Instantiate(explosion,transform.position,transform.rotation);  //สร้าง VFX ในการชนตรงอุกาบาศ
				

		}



	}
}
