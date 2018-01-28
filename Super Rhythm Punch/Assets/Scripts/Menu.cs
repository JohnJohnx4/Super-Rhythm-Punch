using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	public bool isStart;
	public bool isQuit;	
	public bool isMenu;	


	void OnMouseUp(){
		if(isStart)
		{
			print("Start Game!");
			Application.LoadLevel("Level1");
		}
		if(isMenu)
		{
			print("To Menu");
			Application.LoadLevel("menu");
		}
		if (isQuit)
		{	
			print("Quitting...");
			Application.Quit();
		}
	}
}
