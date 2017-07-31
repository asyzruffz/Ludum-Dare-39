using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugSocket : MonoBehaviour {

	Trigger powerSwitch;
	ControllerMechanism mechanism;

	void Start () {
		powerSwitch = GetComponent<Trigger> ();
		mechanism = GetComponent<ControllerMechanism> ();

		powerSwitch.SetActivated (true, false, true);
	}
	
	void Update () {
		mechanism.ControlSwitches ();
	}
}
