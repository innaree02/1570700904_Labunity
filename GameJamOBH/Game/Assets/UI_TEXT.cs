using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_TEXT : MonoBehaviour 
{
	
	public Button Text;
	public Canvas yourcanvas;
	
	
	
	void Start () 
	{
		Text = Text.GetComponent<Button> ();
		yourcanvas.enabled = false;
	}
	
	
	public void Press() 
		
	{
		Text.enabled = true;
		yourcanvas.enabled = true;

		//Destroy(Text,1);

		
	}
}
