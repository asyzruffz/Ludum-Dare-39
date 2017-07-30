using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public float initialTime = 10;
	private float ratio = 0.0f;
	PowerMeter Controls;
	float time;

	// Use this for initialization
	void Start () {
		Controls = GetComponent<PowerMeter> ();
		time = initialTime;
		//ratio = (initialReading*10) / time;
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
		Controls.meterReading -= (Time.deltaTime/initialTime);
		//Controls.meterReading = (time/10)*ratio;
	}
}
