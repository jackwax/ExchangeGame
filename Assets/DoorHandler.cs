using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour {


	private Animator door_controller;
	int openID;

	// Use this for initialization
	void Start () {
		door_controller = this.GetComponent<Animator> ();
		openID = Animator.StringToHash ("isOpen");
	}

	public void touchDoor(){
		bool isOpen = door_controller.GetBool (openID);
		if (!isOpen) {
			door_controller.SetBool ("isOpen", true);
		} else {
			door_controller.SetBool ("isOpen", false);
		}


	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
