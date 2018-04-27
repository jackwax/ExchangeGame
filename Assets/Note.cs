using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour {


	[SerializeField] private GameObject player_ref;
	[SerializeField] private Image noteImg;
	//[SerializeField] private AudioSource mixer;
	[SerializeField] private AudioClip pickupSound;
	[SerializeField] private AudioClip putdownSound;



	// Use this for initialization
	void Start () {
		player_ref = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void ShowNote(){
		player_ref.GetComponent<JohnScript> ().SetLockMovement (); //locks player movement, but still taking input.
		this.transform.position = Camera.main.transform.position+ Camera.main.transform.forward;
		this.transform.eulerAngles = new Vector3 (90f, this.transform.position.y, this.transform.position.z);





	}
}
