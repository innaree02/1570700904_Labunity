using UnityEngine;
using System.Collections;

public class destroybycontract : MonoBehaviour {
	
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;
	void Start()
	{
		GameObject gameControllerobject = GameObject.FindWithTag ("GameController");
		if (gameControllerobject != null) {
			gameController = gameControllerobject.GetComponent <GameController> ();
		}
		if (gameController == null) {
			Debug.Log ("Cannot find 'GameController' Script");
		}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "boundary") {
			return;
		}  
		Instantiate(explosion, transform.position,transform.rotation);
		if (other.tag == "Player") {
			Instantiate(playerExplosion, other.transform.position,other.transform.rotation);
		}
		gameController.AddScore(scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);

	}
}
