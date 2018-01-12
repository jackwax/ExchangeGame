using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnScript : CharacterBehavior {

	Vector3 movedir;
	public float mouseSensitivity = 4f;
	float mouseY;

	// Used for handling the head bobbing animation 
	public Animation movement; 
	//public CharacterController charController;
	public bool left;
	public bool right;


	/* CONTROLLING */
	public float moveSpeed = 500f;

	/**internals**/



	// Use this for initialization
	void Start () {
		CharacterInitialization ();
		InitColor ();
		// The head bobbing will work according to which foot is currently moving, starting with the left foot. 
		left = true;
		right = false;
	}

	void InitColor(){
		AddColor (-7, new Color (32/255f, 0, 0, 1f));
		AddColor (-6, new Color (43/255f, 4/255f, 4/255f, 1f));
		AddColor (-5, new Color(49/255f, 10/255f, 10/255f, 1f ));
		AddColor (-4, new Color (99/255f, 22/255f, 22/255f, 1f));
		AddColor (-3, new Color (120/255f, 27/255f, 27/255f, 1f));
		AddColor (-2, new Color (150/255f, 35/255f, 35/255f, 1f));
		AddColor (-1, new Color (165/255f, 25/255f, 25/255f, 1f));
		AddColor (0, new Color (182/255f, 55/255f, 55/255f, 1f));
		AddColor (1, new Color (192/255f, 16/255f, 25/255f, 1f));
		AddColor (2, new Color (208/255f, 16/255f, 25/255f, 1f));
		AddColor (3, new Color (231/255f, 20/255f, 30/255f, 1f));
		AddColor (4, new Color (231/255f, 57/255f, 30/255f, 1f));
		AddColor (5, new Color (246/255f, 12/255f, 0, 1f));
		AddColor (6, new Color (255/255f, 13/255f, 0, 1f));
		AddColor (7, new Color (255/255f, 61/255f, 51/255f, 1f));
	}



	public bool IsStandingOn( string tagName ) {
		Ray groundCheck = new Ray( rb.transform.position, -Vector3.up );
		RaycastHit groundHit;
		return Physics.Raycast( groundCheck, out groundHit, distToGround + 0.1f ) &&
		groundHit.collider.tag.Equals( tagName );
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMove = Input.GetAxisRaw ("Horizontal");
		float verticalMove = Input.GetAxisRaw ("Vertical");
		movedir = (transform.right * horizontalMove + transform.forward * verticalMove).normalized;
		Look ();	
	}

	public void Look(){
		// Mouse look control:
		transform.Rotate( 0f, Input.GetAxis( "Mouse X" ) * mouseSensitivity, 0f );
		mouseY += Input.GetAxis( "Mouse Y" ) * mouseSensitivity;
		mouseY = Mathf.Clamp( mouseY, -80f, 85f );
		Camera.main.transform.localEulerAngles = new Vector3( -mouseY, 0f, 0f ); //negative mouseY to invert

		//add logic and behavior for walljumping
	}

	public void Move(){
		Vector3 yVelFix = new Vector3( 0, rb.velocity.y, 0 );
		rb.velocity = movedir * moveSpeed * Time.unscaledDeltaTime;
		rb.velocity += yVelFix;	//allows player to be affected by gravity

		// Functionality for head bobbing -- only displayed when John is moving
//		if( charController.isGrounded == true ) {
//			if (left == true) {
//				movement.Play( "left" );
//			} else if ( right == true ) {
//				movement.Play( "right" );
//			}

	}


	void FixedUpdate(){
		print ("move called");
		Move ();
	}

}
