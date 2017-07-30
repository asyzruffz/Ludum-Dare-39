using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ResetMechanism))]
public class PowerMeter : MonoBehaviour {

	[Range(0, 1)]
	public float meterReading;
	public float increment = 0.05f;
	public Transform needle;
	
	ResetMechanism mechanism;
	bool hasPowerSurge = false;

	void Start () {
		mechanism = GetComponent<ResetMechanism> ();
	}
	
	void Update () {
		SurgePower ();

		PointingNeedle ();
	}

	void SurgePower () {
		if (!hasPowerSurge && mechanism.IsOn ()) {
			hasPowerSurge = true;
			meterReading += increment;
			mechanism.ResetSwitches ();
		} else if (hasPowerSurge && !mechanism.IsOn ()) {
			hasPowerSurge = false;
		}
	}

	void PointingNeedle () {
		meterReading = Mathf.Clamp01 (meterReading);
		needle.rotation = Quaternion.AngleAxis (Mathf.Lerp (0, 180, meterReading), Vector3.forward * -1);
	}
}
