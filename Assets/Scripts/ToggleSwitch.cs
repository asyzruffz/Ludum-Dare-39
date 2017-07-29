using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : Trigger {
	
	void Toggle () {
		if (working) {
			SetActivated (!activated);
		}
	}

	void OnMouseDown () {
		Toggle ();
	}
}
