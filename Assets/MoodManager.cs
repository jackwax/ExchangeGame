using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodManager : MonoBehaviour {
	public GameObject target;

	public void IncreaseMood(GameObject target, int value) {
		CharacterBehavior characterController = target.GetComponent<CharacterBehavior>();
		ColorManager colorMan = target.GetComponent<ColorManager> ();
		int last = characterController.mood;
		characterController.mood += value;
		colorMan.ColorMoodChange (last);
	}

	public void DecreaseMood(GameObject target, int value) {
		CharacterBehavior characterController = target.GetComponent<CharacterBehavior>();
		ColorManager colorMan = target.GetComponent<ColorManager> ();
		int last = characterController.mood;
		characterController.mood -= value;
		colorMan.ColorMoodChange (last);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


//
//
//		if (Input.GetKeyDown (KeyCode.Equals))
//			IncreaseMood (target, 1);
//		if (Input.GetKeyDown (KeyCode.Minus))
//			DecreaseMood (target, 1);
//
//
//		print (target.GetComponent<CharacterBehavior> ().mood);

	}
}
