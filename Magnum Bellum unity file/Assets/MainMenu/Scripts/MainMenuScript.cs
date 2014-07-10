using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	private int menuId = 0;
	public GUISkin skin;
	public Texture background;
	// Use this for initialization
	void Start () {
		enabled = true;
		Debug.Log ("Loaded script.");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		GUI.skin = skin;
		GUI.skin.button.fontSize = Screen.height / 16;
		GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), background);
		GUIStyle titleFontSize = new GUIStyle();
		titleFontSize.fontSize = Screen.width / 8 + 5;
		GUI.Label (
			new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 10 * 8, Screen.height / 10 * 8 ), 
			"Magnum Bellum",
			titleFontSize
			);
		switch(menuId){
		case 0:
			if (GUI.Button (new Rect(Screen.width / 4, Screen.height / 8 * 3, Screen.width / 2, Screen.height / 8), "Singleplayer")){
			    menuId = 1;
			}
			if (GUI.Button (new Rect(Screen.width / 4, Screen.height / 16 * 9, Screen.width / 2, Screen.height / 8), "Multiplayer")){
				menuId = 2;
			}
			if (GUI.Button (new Rect(Screen.width / 4, Screen.height / 8 * 6, Screen.width / 2, Screen.height / 8), "Exit Game")){
				menuId = -1;
			}
		break;
		case 1:
			Debug.LogWarning("Not Implemented Yet.");
			menuId = 0;
		break;
		default:
			Debug.Log("Killing process.");
			Application.Quit ();
		break;
		}

	}
}
