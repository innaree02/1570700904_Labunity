using UnityEngine;
using System.Collections;

//คำสั่งดึงค่ามาใช้อีกคลาส
[System.Serializable]
//สร้างอีกคลาส
public class Boundary 
{
	//กำหนดตัวเเปล
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float roatePlayer;
	//เป็นการสร้าง การค่าเชื่อมคลาสโดย ตั้งชื่อ Boundary เเล้วตามด้วย _ชื่อ
	public Boundary _Screen;
	//การสร้างกระสุน
	public GameObject shot;  
	public Transform ShotSpwan; 
	public float FireRate;  //ตัวรั้งการยิง
	private float nextFire; 	//ตัวระยะเวลายิงครั้งต่อไป

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//รับค่าปุ่ม 2 ปุ่ม ขึ้นลง เเละ ซ้ายขวา
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		//กำหนดสร้าง movement มา เเล้ว รับ ค่า x เเละ z  (y เป็นเเนวขึ้นบน)
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
		//การสั่งให้เคลื่อนที่
		rb.velocity = movement * speed ; 

		//ล็อกให้เคลื่อนที่ได้ตามขอบเขต
		rb.position = new Vector3
			(
				//Mathf คือการคำนวน Clamp คือ การกำหนดค่า min เเละ max
				Mathf.Clamp(rb.position.x,_Screen.xMin,_Screen.xMax), 0.0f, Mathf.Clamp(rb.position.z,_Screen.zMin,_Screen.zMax)
			);

		//กำหนดการหมุนของยานในเเกน z เอา rb.velocity.x คือการเคลื่อนที่ในเเกน x คูณกับ การหมุน
		rb.rotation = Quaternion.Euler(0.0f,0.0f, rb.velocity.x * roatePlayer);
	}


	void Update()	
	{
		//คำสั่งยิง หรือ คำสั่งการเพิ่มวัตถุตามเวลา
		if(Input.GetButton("Fire1")&&Time.time > nextFire)
		{
			nextFire = Time.time + FireRate; 
			//คำสั่งการเพิ่ม วัตถุโดย shot คือ อ็อปเจ็ค ที่จะสร้าง ShotSpwan.position คือ ตำเเหน่งของวัตถุที่จะเกิด
			Instantiate(shot ,ShotSpwan.position,ShotSpwan.rotation);
		}
	}
}
