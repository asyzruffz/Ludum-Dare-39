using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChaosSystemMechanism : OutputMechanism {

	[Header("Storage")]
	public Mechanism container;

	public void ProcessSwitches () {
		RandomizeTriggerList ();

		for (int i = 0; i < 4; i++) {
			container.Triggers.Add (Controls[i]);
			Controls[i].PreRequisites.Add (Controls[(2 * i + 4)]);
			Controls[i].PreRequisites.Add (Controls[(2 * i + 5)]);
			Controls[(2 * i + 4)].PreRequisites.Add (Controls[i + 12]);
		}
	}
	
	void RandomizeTriggerList () {
		Controls.OrderBy ((item) => Random.Range (0, int.MaxValue));
	}
}
