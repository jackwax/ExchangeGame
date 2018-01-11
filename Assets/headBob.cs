using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class used for animating a head bob when a player is moving 
public class headBob : MonoBehaviour {

    // Animation instance used for accessing animation methods and CharacterController used for 
	// accessing player information 
    public Animation bob;
	public CharacterController player; 

    // Boolean flags used to determine which foot is on the ground and if the player is moving
    private bool left;
    private bool right; 
	private bool moving;

	// Allows access to John's script, used for telling whether or not the player is moving 
	JohnScript js;

    // Use this for initialization
    // Starts with the left foot moving first
    void Start () {

        left = true;
        right = false;
		js = GetComponent<JohnScript> ();
		moving = js.isMoving;

    }
    
    // Update is called once per frame
    // Gets the current position of the player and calls the head bobbing animation if the
    // player is moving. 
    void Update () {
        
		moving = js.isMoving;
        if( moving ){
            headBobAnimation();
        }
        
    }

    // Assesses which animation to play ( or none at all ) based on the boolean flags
    void headBobAnimation() {
  
        if( player.isGrounded ){
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
    
}
