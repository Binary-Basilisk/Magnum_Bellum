using UnityEngine;
using System.Collections;

public class MultiplayerButtonScript : MonoBehaviour {

	private static Color defaultColor;
	
	void Start(){
		defaultColor = guiTexture.color;
	}
	
	void OnMouseEnter(){
		guiTexture.color = new Color(255, 0, 0, 128);
	}
	
	void OnMouseExit(){
		guiTexture.color = defaultColor;
	}
	
	void OnMouseDown(){
		GameObject.Find("SingleplayerButton").transform.Translate(new Vector3 (10, 0, 0));
		GameObject.Find("MultiplayerButton").transform.Translate(new Vector3 (10, 0, 0));
		GameObject.Find("ExitGameButton").transform.Translate(new Vector3 (10, 0, 0));
	}
}
