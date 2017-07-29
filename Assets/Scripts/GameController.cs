using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	ChaosSystemMechanism mechanism;

	void Start () {
		mechanism = GetComponent<ChaosSystemMechanism> ();
	}
	
	void Update () {
		if (mechanism.IsOn ()) {
			mechanism.ProcessSwitches ();
		}
	}
}
