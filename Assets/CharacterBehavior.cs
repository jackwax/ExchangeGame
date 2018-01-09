using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour {

	[HideInInspector] public static Rigidbody rb; 

	public int mood;


	[HideInInspector] public Color badColor;
	[HideInInspector] public Color goodColor;

	[HideInInspector] public float distToGround;



	// Use this for initialization
	public void CharacterInitialization(){
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
		distToGround = GetComponent<Collider> ().bounds.extents.y;

		mood = 0;
	}

	//check if we've touched ground








	void Start () {
		CharacterInitialization ();


		
	}
		
	
	// Update is called once per frame
	void Update () {

	}
}
