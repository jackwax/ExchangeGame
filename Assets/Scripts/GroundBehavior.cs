using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class GroundBehavior : MonoBehaviour {

	public List<GroundType> groundtypes;

	public AudioSource aS;

	public CharacterBehavior cbref;

	// Use this for initialization
	void Start () {
		initGround ();
		aS = this.GetComponent<AudioSource> ();
		cbref = this.GetComponent<CharacterBehavior> ();

		
	}


	void OnCollisionStay(Collision other){
		GameObject groundon = other.gameObject;
		SetGround (groundon);
		


	}


	void initGround(){


		var groundsounds = Resources.LoadAll ("Audio/Footsteps", typeof(AudioClip));
		foreach (AudioClip sound in groundsounds) {
			GroundType newgt = new GroundType ();
			newgt.ground_sound = sound;
			newgt.name = sound.name;

			groundtypes.Add (newgt);
		}
		
//		DirectoryInfo dir = new DirectoryInfo ("Assets/Resources/Audio/Footsteps");
//		FileInfo[] info = dir.GetFiles ();
//		var fullNames = info.Select(f => f.FullName).ToArray();
//		foreach (string f in fullNames) {
//			GroundType newGT = new GroundType ();
//			newGT.name = f;
//			newGT.ground_sound = Resources.Load()
//
//
//		}






	}


	public void SetGround(GameObject on){
		if (on.tag == "carpet") {
			aS.clip = groundtypes [0].ground_sound;
		} else if (on.tag == "tile") {
			aS.clip = groundtypes [1].ground_sound;

		} else if (on.tag == "wood") {
			aS.clip = groundtypes [2].ground_sound;
		}
			



	}


	void playSound(){
		if (cbref.isMoving() == true && !aS.isPlaying){
			aS.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		playSound ();

		
	}
}



[System.Serializable]
public class GroundType {
	public string name;
	public AudioClip ground_sound;


}
