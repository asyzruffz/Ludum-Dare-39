using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public AudioClip onSound;
	public AudioClip offSound;
	public AudioClip errorSound;

	public List<Trigger> PreRequisites = new List<Trigger> ();

	protected bool activated = false;
	protected bool working = true;
	protected Animator anim;
	AudioSource aud;

	void Awake () {
		anim = GetComponent<Animator> ();
		aud = GetComponent<AudioSource> ();
	}

	public bool IsActivated () {
		return activated;
	}
	
	public virtual void Reset () {
		SetActivated (false);
        PreRequisites.Clear ();

    }

	public void SetActivated (bool activate, bool withSound = true, bool ignorePrerequisite = false) {
		bool satisfied = working && (ignorePrerequisite || PassPrerequisites ());
		activated = satisfied && activate;

		if (anim) {
			anim.SetBool ("IsPressed", activated);
			anim.SetBool ("IsError", !satisfied);
		}

		if (aud && withSound) {
			if (onSound && activated) {
				aud.PlayOneShot (onSound);
			}
			if (offSound && !activated && satisfied) {
				aud.PlayOneShot (offSound);
			}
			if (errorSound && !satisfied) {
				aud.PlayOneShot (errorSound);
			}
		} else if (!aud) {
			Debug.Log (gameObject.name + ": No AudioSource added!");
		}
	}

	public void SetWorking (bool work) {
		working = work;
	}
	
	bool PassPrerequisites() {
		if (PreRequisites.Count > 0) {
			foreach (Trigger trigger in PreRequisites) {
				if (!trigger.IsActivated()) {
					return false;
				}
			}
		}

		return true;
	}
}
