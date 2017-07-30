using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowCity : MonoBehaviour {

	public PowerMeter meter;

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void Update () {
		anim.SetFloat ("Voltage", meter.meterReading);
	}
}
