using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScreen : MonoBehaviour {

	public float fadeTime = 1;

	Image img;
	float timer = 0;
	bool startFading = true;
	bool toBlack = false;

	void Start () {
		img = GetComponent<Image> ();
	}
	
	void Update () {
		if (startFading) {
			timer += Time.deltaTime;
			float t = Mathf.Clamp01 (timer / fadeTime);
			img.color = Color.Lerp (toBlack ? Color.clear : Color.black,
									toBlack ? Color.black : Color.clear, t);

			if (t >= 1) {
				toBlack = !toBlack;
				startFading = false;
				timer = 0;
				if (!toBlack) {
					Invoke ("DelayedRestart", 3);
				}
			}
		}
	}

	public void FadeToBlack() {
		startFading = true;
	}

	void DelayedRestart() {
		SceneManager.LoadScene (0);
	}
}
