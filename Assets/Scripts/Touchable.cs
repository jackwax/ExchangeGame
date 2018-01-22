using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchable : MonoBehaviour {

	public AudioSource fxs;
	bool isActive;
	bool completed;


	private Animator obj_controller;
	int objID;



	// Use this for initialization
	void Start () {
		fxs = this.gameObject.AddComponent<AudioSource> ();
		isActive = false;
		completed = false;
		obj_controller = this.gameObject.GetComponent<Animator> ();
		objID = Animator.StringToHash ("isPlaying");
	}


	/**public void SetAudio(string clipname){
		fxs = clipname;
	}**/
	public void touchObject(){
		bool isPlaying = obj_controller.GetBool (objID);
		if (!isPlaying) {
			obj_controller.SetBool ("isPlaying", true);
			StartCoroutine (PlayRevAnim ());
		}
	}

	IEnumerator PlayRevAnim(){
		yield return new WaitForSeconds(2.0f);
		obj_controller.SetBool ("isPlaying", false);


	}



	
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
