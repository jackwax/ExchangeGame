using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairColor : MonoBehaviour {

	public Interactable inc;

	Image chimg;
	Color defColor;

	// Use this for initialization
	void Start () {

		chimg = this.GetComponent<Image> ();
		defColor = this.GetComponent<Image> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		if (inc.isInteractable () == true) {
			print ("this is true");
			chimg.color = new Color (1, 0, 0);
		} else {
			chimg.color = defColor;
		}
		
	}
}
