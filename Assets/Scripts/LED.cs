using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : MonoBehaviour {

	public Trigger LEDSwitch;

	SpriteRenderer sprite;

	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	void Update () {
		if (LEDSwitch) {
			sprite.color = LEDSwitch.IsActivated () ? Color.green : Color.white;
		}
	}
}
