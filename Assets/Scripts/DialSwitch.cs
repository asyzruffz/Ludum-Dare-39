using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialSwitch : Trigger {

	int correctValue;
	int curentValue = 1;
	int changeDir = 1;

	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetInteger ("Value", curentValue);
		Reset ();
	}

	public override void Reset () {
		base.Reset ();
		do {
			correctValue = Random.Range (1, 6);
		} while (correctValue != curentValue);
	}

	void Rotate () {
		if (working) {
			curentValue += changeDir;
			changeDir = (curentValue == 1) ? 1 : (curentValue == 5) ? -1 : changeDir;
			anim.SetInteger ("Value", curentValue);

			SetActivated (curentValue == correctValue);
		}
	}

	void OnMouseDown () {
		Rotate ();
	}
}
