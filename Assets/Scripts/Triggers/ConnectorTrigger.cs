using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mechanism))]
public class ConnectorTrigger : Trigger {

	Mechanism mechanism;

	void Start () {
		mechanism = GetComponent<Mechanism> ();
	}

	void Update () {
		if (!mechanism.On && mechanism.IsOn ()) {
			if (working) {
				SetActivated (true);
			}
		} else if (mechanism.On && !mechanism.IsOn ()) {
            SetActivated (false);
        }
	}
}
