using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDescriptions : MonoBehaviour {

	public Interactable object_checker;
	public Text obj_text;

	// Use this for initialization
	void Start () {
		object_checker = Camera.main.gameObject.GetComponent<Interactable> ();

		obj_text = this.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		GameObject obj = object_checker.getHoveredObject ();

		if (obj != null && object_checker.isInteractable()) {
			obj_text.text = obj.gameObject.name;
		} else {
			obj_text.text = "";
		}
		
	}
}
