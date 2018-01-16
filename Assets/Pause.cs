using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	bool paused = false;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P))
			paused = togglePause ();
			
	}

	void OnGUI(){
		
		if (paused) {
			GUILayout.BeginArea (new Rect((Screen.width/2)-50, (Screen.height/2) , 100, 100));
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Paused");

			if (GUILayout.Button ("Resume"))
				paused = togglePause ();
			GUILayout.FlexibleSpace ();
			GUILayout.EndArea ();
		}
	}
	bool togglePause(){
		if (Time.timeScale == 0f) {
			Time.timeScale = 1f;
			return (false);
		} else {
			Time.timeScale = 0f;
			return (true);
		}
	}
}
