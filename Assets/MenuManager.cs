using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private Image black_background;
	[SerializeField] private ScreenFader sf;


/**TODO:
 * Start button functionality that onclick:
 *		-Makes the start button disappear, as well as the logo
 *			-I believe we can do this using Unity's "Set Active" feature on OnClick listeners (thx Unity)
 *		-Prompts users to enter their names
 *		-Enacts an "You Want to be Called" / "You're calling Yourself" [Name] and prompts users to select yes / no
 *		-If no, returns back for the users to put in their names
 *			-I think this can also be done with "Set Active" functionality
 *
 *
 *In conclusion, we can do this shit XD. 
 **/



	void Start () {
		
		
	}


	void PrintMsg(){
		print ("button has been pressed");

	}

	public void PlayGame(){
		sf.EndScene (SceneManager.GetActiveScene ().buildIndex + 1);



	}

	public void QuitGame(){
		Application.Quit ();
		Debug.Log ("Quit");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
