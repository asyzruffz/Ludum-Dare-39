using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Countdown timer;
	public FadeScreen curtainClose;

	ChaosSystemMechanism mechanism;
	bool newlyOpened = true;
	bool stillPlaying = true;

	void Start () {
		mechanism = GetComponent<ChaosSystemMechanism> ();
		mechanism.ProcessSwitches ();
	}
	
	void Update () {
		if (newlyOpened && Input.GetMouseButtonDown (0)) {
			timer.started = true;
			newlyOpened = false;
		}

		if (stillPlaying && timer.finished) {
			curtainClose.FadeToBlack ();
			stillPlaying = false;
		}

		if (mechanism.IsOn ()) {
			mechanism.ProcessSwitches ();
		}
	}
}
