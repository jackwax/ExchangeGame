using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnScript : CharacterBehavior {

	Vector3 movedir;
	public float mouseSensitivity = 4f;
	float mouseY;




	/* CONTROLLING */
	public float moveSpeed = 500f;

	/**internals**/



	// Use this for initialization
	void Start () {
		goodColor = new Color (255, 43, 43, 255);
		badColor = new Color (111, 24, 24, 255);
		CharacterInitialization ();
		
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
	}


	void FixedUpdate(){
		Move ();
	}




}
