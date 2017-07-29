using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMechanism : OutputMechanism {
	
	public void ControlSwitches () {
		bool switchedOn = IsOn ();
		foreach (Trigger trigger in Controls) {
			trigger.SetWorking (switchedOn);
		}
	}
}
