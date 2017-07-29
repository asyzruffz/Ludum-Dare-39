using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTapSwitch : Trigger {

	[Range(1, 100)]
	public int tapRequired = 3;
	public float cancelTime = 1;
	public float restTime = 3;

	[Space]
	public bool inverse;

	float timer = 0;
	int currentTap = 0;
	bool stunned = false;

	void Update () {
		if (currentTap > 0) {
			timer += Time.deltaTime;
		}

		if (timer >= ((activated ^ inverse) ? restTime : cancelTime)) {
			timer = 0;
			currentTap = 0;
			stunned = false;
		}
	}

	void TapTap () {
		if (working) {
			if (activated ^ inverse) { // XOR operation uses '^'
				if (!stunned) {
					SetActivated (inverse);
				}
			} else {
				currentTap++;
				timer = 0;

				if (currentTap >= tapRequired && timer < cancelTime) {
					SetActivated (!inverse);
					stunned = true;
				}
			}
		}
	}

	void OnMouseDown () {
		TapTap ();
	}
}
