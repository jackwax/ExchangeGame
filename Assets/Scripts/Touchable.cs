using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchable : MonoBehaviour {

	public AudioSource fxs;
	bool isActive;
	bool completed;




	// Use this for initialization
	void Start () {
		fxs = this.gameObject.AddComponent<AudioSource> ();
		isActive = false;
		completed = false;
	}


	/**public void SetAudio(string clipname){
		fxs = clipname;
	}**/
	
	// Update is called once per frame
	void Update () {
		
	}



	public void setActive(){
		if(!completed)
		isActive = true;
	}

	public void deactivate(){
		isActive = false;
	}


	public void Activate(){
		if (isActive) {
			fxs.Play ();
			//play animation
			deactivate();
			completed = true;
		}
	}
}
