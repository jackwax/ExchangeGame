using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodManager : MonoBehaviour {
	public GameObject target;

	void IncreaseMood(GameObject target, int value) {
		CharacterBehavior characterController = target.GetComponent<CharacterBehavior>();
		characterController.mood += value;
	}

	void DecreaseMood(GameObject target, int value) {
		CharacterBehavior characterController = target.GetComponent<CharacterBehavior>();
		characterController.mood -= value;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {




		if (Input.GetKeyDown (KeyCode.Equals))
			IncreaseMood (target, 1);
		if (Input.GetKeyDown (KeyCode.Minus))
			DecreaseMood (target, 1);


		print (target.GetComponent<CharacterBehavior> ().mood);

	}
}
