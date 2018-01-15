using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour {

	//public Rigidbody rb;
	// Use this for initialization
	public Collider col;

	void Start () {
		//rb = this.gameObject.AddComponent<Rigidbody> ();
		col = this.gameObject.GetComponent<Collider>();
	}


	public void SendMessage(){
		print ("You have touched " + this.name+ "!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
