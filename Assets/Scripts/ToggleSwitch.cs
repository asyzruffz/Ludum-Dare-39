using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : Trigger {
	
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			activated = !activated;
		}
	}
}
