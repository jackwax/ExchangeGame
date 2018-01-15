using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JackieScript : CharacterBehavior {

	public NavMeshAgent navAI;
	public GameObject johnref;

	bool talktojohn;

	// Use this for initialization
	void Start () {
		colorlist = new Dictionary<int, Color> ();
		talktojohn = false;
		navAI = this.GetComponent<NavMeshAgent> ();
		johnref = GameObject.Find ("Player");

	}


	void toggleTalking(){
		talktojohn = !talktojohn;
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Backspace)){
			toggleTalking();
		}


		if (talktojohn) {
			navAI.SetDestination(johnref.transform.position);



		}



		
	}
}
