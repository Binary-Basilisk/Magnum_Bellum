using UnityEngine;
using System.Collections;

public class ExitButtonScript : MonoBehaviour {

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
		Application.Quit();
	}
}
