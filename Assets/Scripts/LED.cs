using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mechanism))]
public class LED : MonoBehaviour {
	
	SpriteRenderer sprite;
	Mechanism mechanism;

	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		mechanism = GetComponent<Mechanism> ();
	}
	
	void Update () {
		sprite.color = mechanism.IsOn () ? Color.green : Color.red;
	}
}
