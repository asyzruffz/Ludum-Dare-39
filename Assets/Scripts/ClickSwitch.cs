using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSwitch : Trigger {
	
	void Click () {
		activated = true;
	}

	void OnMouseDown () {
		Click ();
	}
}
