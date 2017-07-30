using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float totalTime = 10;

	PowerMeter meter;
	
	void Start () {
		meter = GetComponent<PowerMeter> ();
	}
	
	void Update () {
		meter.meterReading -= (Time.deltaTime / totalTime);

		if (meter.meterReading <= 0) {
			meter.meterReading = 0;
		}
	}
}
