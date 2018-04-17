using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour {

	//[HideInInspector] public static Rigidbody rb; 

	public int mood;


	public Dictionary <int, Color> colorlist;


	[HideInInspector] public float distToGround;

	private Vector3 prevPos;

	public bool currentlymoving;

	public Rigidbody rb;






	// Use this for initialization
	public void CharacterInitialization(){
		//colorlist = new Dictionary<int, Color> ();

		mood = 0;
	}

//	public void AddColor(int index, Color col){
//		colorlist.Add (index, col);
//	}


	public bool isMoving(){
		Vector3 curMove = transform.position - prevPos;
		float curSpeed = curMove.magnitude/Time.deltaTime;
		prevPos = transform.position;

		//print (curSpeed);

		if (curSpeed >0.5f || rb.velocity.magnitude > 0) {
			return true;
		} else {
			return false;
		}
//		if (rb.velocity.magnitude > 0.5f) {
//			return true;
//		} else {
//			return false;
//		}
//



	}

	//check if we've touched ground








	void Start () {
		CharacterInitialization ();
		rb = this.GetComponent<Rigidbody> ();


		
	}
		
	
	// Update is called once per frame
	void Update () {
		currentlymoving = isMoving ();


		//print (this.gameObject.name + " has a velocity of" + rb.velocity.magnitude);
		
		

	}

}
