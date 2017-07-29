using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ResetMechanism))]
public class PowerMeter : MonoBehaviour {

	[Range(0, 1)]
	public float meterReading;
	public float increment = 0.05f;

	SpriteRenderer sprite;
	ResetMechanism mechanism;
	bool hasPowerSurge = false;

	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		mechanism = GetComponent<ResetMechanism> ();
	}
	
	void Update () {
		SurgePower ();

		meterReading = Mathf.Clamp01 (meterReading);
		sprite.color = Color.Lerp (Color.black, Color.yellow, meterReading);
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
}
