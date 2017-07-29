using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public List<Trigger> PreRequisites = new List<Trigger> ();

	protected bool activated = false;
	protected bool working = true;

	public bool IsActivated () {
		return working && PassPrerequisites () && activated;
	}
	
	public void Reset () {
		activated = false;
	}

	public void SetActivated (bool activate) {
		activated = activate;
	}

	public void SetWorking (bool work) {
		working = work;
	}
	
	bool PassPrerequisites() {
		if (PreRequisites.Count > 0) {
			foreach (Trigger trigger in PreRequisites) {
				if (!trigger.IsActivated()) {
					return false;
				}
			}
		}

		return true;
	}
}
