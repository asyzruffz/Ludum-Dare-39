using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float time = 0.0f;
	private float ratio = 0.0f;
	PowerMeter Controls;

	// Use this for initialization
	void Start () {
		Controls = GetComponent<PowerMeter> ();
		ratio = (Controls.meterReading*10) / time;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;	
		if (time <= 0){
			time = 0;			
		}
		if (Controls.meterReading <= 0){
			Controls.meterReading = 0;			
		}
		Controls.meterReading = (time/10)*ratio;
	}
}
