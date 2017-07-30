using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMechanism : OutputMechanism {
	
	public void ResetSwitches () {
		foreach (Trigger trigger in Controls) {
			trigger.Reset ();
		}
	}
}
