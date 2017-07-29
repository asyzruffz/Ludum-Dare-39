using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMechanism : Mechanism {

	[Header ("Output")]
	public List<Trigger> Controls = new List<Trigger> ();
	
	public void ControlSwitches () {
		bool switchedOn = IsOn ();
		foreach (Trigger trigger in Controls) {
			trigger.SetWorking (switchedOn);
		}
	}
}
