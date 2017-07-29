using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMechanism : Mechanism {

	[Header ("Output")]
	public List<Trigger> Controls = new List<Trigger> ();
	
	public void ResetSwitches () {
		foreach (Trigger trigger in Controls) {
			trigger.Reset ();
		}
	}
}
