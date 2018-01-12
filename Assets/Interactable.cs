using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {
	public Camera mc;

	public Image crosshair;

	GameObject hoveredObject;



	// Use this for initialization
	void Start () {
		mc = Camera.main;

		crosshair = GameObject.Find ("Crosshair").GetComponent<Image>();


		
	}
	
	// Update is called once per frame
	void Update () {
		bool canInteract = isInteractable ();


		if (canInteract == true) {
			if (Input.GetKeyUp (KeyCode.Mouse0)) {
				hoveredObject.GetComponent<Thing> ().SendMessage ();
			}

		}
		
	}

	/**to determine whether the thing in the crosshair is interactable**/
	public bool isInteractable(){
		crosshair.transform.position = Input.mousePosition;
		Ray romano = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();

		Debug.DrawRay (romano.origin, romano.direction * 2f, Color.green);





		if (Physics.Raycast (romano, out hit, 2f)) {
			hoveredObject = hit.collider.gameObject;

			//print ("yeh");
			if (hit.collider.gameObject.tag == "touchable") {
				return true;

			} else if (hit.collider.gameObject.tag == "pickup") {
				return true;
			} else {
				return false;
			}

		}
		hoveredObject = null;
		return false;

	}



}
