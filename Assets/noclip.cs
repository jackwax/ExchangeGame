using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Noclip camera used for testing
public class noclip : MonoBehaviour {

	// Camera speed
	public float speed = 50.0f;

	// Adjusts prevMouse calculations by a sensitivity factor 
	private float sensitivity = 0.25f;

	// Previous mouse position
	private Vector3 prevMouse = new Vector3( 255, 255, 255 );

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Mouselook
		prevMouse = Input.mousePosition - prevMouse;
		// Inverts rotation 
		prevMouse.y = -prevMouse.y; 
		prevMouse *= sensitivity;
		prevMouse = new Vector3 (transform.eulerAngles.x + prevMouse.y, transform.eulerAngles.y + prevMouse.x, 0);
		transform.eulerAngles = prevMouse;
		// Reset the previous mouse position 
		prevMouse = Input.mousePosition;

		// WASD movement
		//
		// Direction vector
		Vector3 direction = new Vector3 ();
		// Key input
		if (Input.GetKey (KeyCode.W)) {
			direction.z += 1f;
		}
		if (Input.GetKey (KeyCode.S)) {
			direction.z -= 1f;
		}
		if (Input.GetKey (KeyCode.D)) {
			direction.x += 1f;
		}
		if (Input.GetKey (KeyCode.A)) {
			direction.x -= 1f;
		}
		// Normalize vector and translate position 
		direction.Normalize ();
		transform.Translate (direction * speed * Time.deltaTime);

	}

}
