using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class used for animating a head bob when a player is moving 
public class headBob : MonoBehaviour {

    // Animation instance used for accessing animation methods
    public Animation bob; 

    // Boolean flags used to determine which foot is on the ground and if the player is moving
    private bool left;
    private bool right; 
    private bool isMoving;

	// Allows access to John's script, used for telling whether or not the player is moving 
	JohnScript js;

    // Use this for initialization
    // Starts with the left foot moving first
    void Start () {

        left = true;
        right = false;

    }
    
    // Update is called once per frame
    // Gets the current position of the player and calls the head bobbing animation if the
    // player is moving. 
    void Update () {
		
		float horizontalMove = Input.GetAxisRaw ("Horizontal");
		float verticalMove = Input.GetAxisRaw ("Vertical");
		if (verticalMove != 0 || horizontalMove != 0) {
			isMoving = true;
		} else {
			isMoving = false;
		}
        if( isMoving ){
            headBobAnimation();
        }
        
    }

    // Assesses which animation to play ( or none at all ) based on the boolean flags
    void headBobAnimation() {
      
        if( left ){
            if( !bob.isPlaying ){
                bob.Play( "left" );
                left = false;
                right = true;
            }
        }
        if( right ){
            if( !bob.isPlaying ){
                bob.Play( "right" );
                left = true;
                right = false;
            }
        }

    }
    
}
