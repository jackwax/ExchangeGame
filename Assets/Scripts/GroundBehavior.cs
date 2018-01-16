using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehavior : MonoBehaviour {

	public List<GroundType> groundtypes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



[System.Serializable]
public class GroundType {
	string name;
	AudioClip ground_sound;


}
