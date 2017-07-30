using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resign : MonoBehaviour {

	Animator anim;
	Trigger trigger;
	bool clicked = false;

	void Start () {
		anim = GetComponent<Animator> ();
		trigger = GetComponent<Trigger> ();
	}
	
	void Update () {
		if (!clicked && trigger.IsActivated()) {
			clicked = true;
			Application.Quit ();
		}
	}

	void OnMouseEnter () {
		anim.SetBool ("IsPressed", true);
	}

	void OnMouseExit () {
		anim.SetBool ("IsPressed", false);
	}
}
