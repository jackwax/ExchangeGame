using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour {

	private AudioSource door_sound_source;
	private Animator door_controller;
	int openID;

	// Use this for initialization
	void Start () {
		door_controller = this.GetComponent<Animator> ();
		openID = Animator.StringToHash ("isOpen");
		door_sound_source = this.GetComponent<AudioSource> ();
	}

	public void touchDoor(){
		bool isOpen = door_controller.GetBool (openID);
		if (!isOpen) {
			door_controller.SetBool ("isOpen", true);
		} else {
			door_controller.SetBool ("isOpen", false);
		}


	}

	public void PlayAudio(AudioClip sound){
		if (door_sound_source && sound) {
			door_sound_source.clip = sound;
			door_sound_source.Play ();


			
		}

	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
