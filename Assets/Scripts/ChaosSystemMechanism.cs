using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosSystemMechanism : OutputMechanism {

	[Header("Storage")]
	public Mechanism container;

	public void ProcessSwitches () {
		foreach (Trigger trigger in Controls) {
			//trigger.Reset ();
		}
	}

	void PushToContainer (Trigger trigger) {
		container.Triggers.Add (trigger);
	}
}
