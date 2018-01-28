	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {
	public Camera mc;

	public Image crosshair;

	private GameObject hoveredObject;



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
				/**Interact logic goes here. Objects should call their own interact methods**/
				if (hoveredObject.tag == "touchable") {
					hoveredObject.GetComponent<Touchable> ().touchObject ();

				} else if (hoveredObject.tag == "pickup") {
					//hoveredObject.GetComponent<PickUp>().pickUp();
				} else if (hoveredObject.tag == "door") {
					hoveredObject.GetComponentInParent<DoorHandler> ().touchDoor();
				}

			}

		}
		
	}

	public GameObject getHoveredObject(){
		return hoveredObject;
	}






	/**to determine whether the thing in the crosshair is interactable**/
	public bool isInteractable(){
		Ray romano = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();

		Debug.DrawRay (romano.origin, romano.direction * 2f, Color.green);
		if (Physics.Raycast (romano, out hit, 2f)) {
			hoveredObject = hit.collider.gameObject;

			//print ("yeh");
			if (hit.collider.gameObject.tag == "touchable" || hit.collider.gameObject.tag == "pickup" || hit.collider.gameObject.tag == "door") {
				return true;
			} else {
				return false;
			}

		}
		hoveredObject = null;
		return false;

	}



}
