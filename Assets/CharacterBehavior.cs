using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour {

	[HideInInspector] public static Rigidbody rb; 

	public int mood;


	public Dictionary <int, Color> colorlist;

	[HideInInspector] public float distToGround;





	// Use this for initialization
	public void CharacterInitialization(){
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
		distToGround = GetComponent<Collider> ().bounds.extents.y;
		colorlist = new Dictionary<int, Color> ();

		mood = 0;
	}

	public void AddColor(int index, Color col){
		colorlist.Add (index, col);
	}

	//check if we've touched ground








	void Start () {
		CharacterInitialization ();


		
	}
		
	
	// Update is called once per frame
	void Update () {

	}

}
