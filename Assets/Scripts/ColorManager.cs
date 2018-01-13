using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {
	public GameObject target;
	public CharacterBehavior behave;

	public Color endColor;

	//rend: Renderer component of target game object.
	public Renderer rend;

	//toLerp: boolean flag for use in update(). Set to true when new endColor is set.
	public bool toLerp = false;

	//Params for mechanics of color interpolation. 
	public float lerpDuration = 2.0f;
	public float t=0.0f;


	void Start () {
		target = behave.gameObject;
		rend = target.GetComponent<Renderer> ();
	}

	/*
	 * Set the target color to interpolate to.
	 * The actual process of changing the color happens in update(), so we also set the boolean flag toLerp to true.
	 */
	public void ColorMoodChange(int lastMood){
		endColor = behave.colorlist[lastMood];
		toLerp = true;
	}




	// Update is called once per frame
	void Update () {

		if (toLerp) {
			if (t <= 1) {
				Color c = Color.Lerp (endColor, behave.colorlist[behave.mood], t);
				t += Time.deltaTime / lerpDuration;
				rend.material.color = c;
			}else{
				toLerp = false;
				t = 0.0f;
			}
		}

	}
}
