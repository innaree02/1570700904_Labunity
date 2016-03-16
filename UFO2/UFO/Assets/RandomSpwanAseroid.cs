
using UnityEngine;
using System.Collections;

public class RandomSpwanAseroid : MonoBehaviour {
	public GameObject wanrring;
	public Vector3 spawnPosition;


	public int valueAstoid;  //จำนวนของอุกาบาตที่มี
	public float spawnWait; //เวลาของอุกาบาตที่จะเกิด
	public float WaveWait;  //เวลาของด่าน
	public float StartGame; //เวลาตอนเริ่มเกม ว่าอุกาบาตจะเกิดในอีกกี่นาที

	void Start () {
		//คำสั่งการเรียกใช้เรื่องเวลาจะต้องเพิ่ม StartCoroutine
		StartCoroutine (SpwanWaves());
	
	}
	//คำสั่งพิเศษ เรื่อง เวลาจะต้องมี IEnumerator ซึ่งเชื่อมโยงกับบรรทัดที่ 16 ในการสร้างเเละเรียกใช้ ฟังก์ชัน
	IEnumerator SpwanWaves()
	{
		yield return new WaitForSeconds(StartGame);   //คำสั่งหน่วงเวลาในเกมตอนเริ่ม

		while(true)     //ให้ค่า while เป็นจริงเสมอ 
		{
			for(int i = 0; i< valueAstoid;i++)   //ให้ค่า i เป็น 0 จำวนอุกาบาศน้อยกว่า i ให้ ค่า i เพื่มทีละ 1
			{
				//กำหนดให้  spawnAbslotid นั้น มีค่า vector3 ใหม่โดยจะเป็นการสุ่มตำเเหน่ง เเกน x y z โดยต้องกำหนดตัวเเปลอ้างอิงบรรทัดที่ 7
				Vector3 spawnAbslotid = new Vector3(Random.Range(-spawnPosition.x ,spawnPosition.x), spawnPosition.y, spawnPosition.z);

				//คำสั่งในการหมุนเเบบ เเรนดอม Quaternion.identity คือหมุนตามตัวมันเองตามวัตถุ 
				Quaternion spawnRotation = Quaternion.identity;			

				//คำสั่งการสร้างวัตถุ โดยให้อุกาบาต มาตรงตำเเหน่งที่อ้างอิงใหม่ในบรรทัด 29 เเละการหมุนในบรรทัด 32
				Instantiate(wanrring,spawnAbslotid,spawnRotation);

				//คำสั่งให้หน่วงเวลาการเกิดของอุกาบาต เมื่อหน่วงเสร็จจะวนกลับไปทำงานใน for จนครบ 
				yield return new WaitForSeconds(spawnWait);
			}	

			yield return new WaitForSeconds(WaveWait); //คำสั่งในการรอเวลาจบจาก for จนครบ จะมาทำงานใน while ถ้า while เป็นจริงจะกลับมาทำงาน ใน for ใหม่
		}
	}
}
