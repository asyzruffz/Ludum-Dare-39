using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugSocket : MonoBehaviour {

	ToggleSwitch powerSwitch;
	ControllerMechanism mechanism;

	void Start () {
		powerSwitch = GetComponent<ToggleSwitch> ();
		mechanism = GetComponent<ControllerMechanism> ();

		powerSwitch.SetActivated (true);
	}
	
	void Update () {
		mechanism.ControlSwitches ();
	}
}
