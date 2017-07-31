using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChaosSystemMechanism : OutputMechanism {

	[Header("Storage")]
	public Mechanism container;

	public void ProcessSwitches () {
		RandomizeTriggerList ();

        container.Triggers.Clear ();
        for (int i = 0; i < 4; i++) {
			container.Triggers.Add (Controls[i]);
			Controls[i].PreRequisites.Add (Controls[(2 * i + 4)]);
			Controls[i].PreRequisites.Add (Controls[(2 * i + 5)]);
			Controls[(2 * i + 4)].PreRequisites.Add (Controls[i + 12]);
		}
	}
	
	void RandomizeTriggerList () {
        Shuffle ();
        if (Random.value <= 0.5f) {
			Controls.Reverse ();
		}
	}

    void Shuffle () {
        for (int i = Controls.Count - 1; i > 0; i--) {
            ListSwap (i, Random.Range (0, i - 1));
        }
    }

    void ListSwap (int indexA, int indexB) {
        Trigger tmp = Controls[indexA];
        Controls[indexA] = Controls[indexB];
        Controls[indexB] = tmp;
    }
}
