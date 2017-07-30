using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanism : MonoBehaviour {

	[ShowOnly]
	public bool On = false;
	[Header ("Input")]
	public List<Trigger> Triggers = new List<Trigger> ();
	
	public bool IsOn () {
		if (Triggers.Count > 0) {
			foreach (Trigger trigger in Triggers) {
				if (!trigger.IsActivated ()) {
					On = false;
					return false;
				}
			}
		} else {
			On = false;
			return false;
		}

		On = true;
		return true;
	}
}
