using UnityEngine;
using System.Collections;

using UnityStandardAssets.CrossPlatformInput;

public class AtesEt : MonoBehaviour {
	public float mermiAraligi = 0.5f;
	public GameObject mermi;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetButton ("Fire1")) {
			Debug.Log ("GetButton");
		}*/
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
			Debug.Log ("GetButtonDown");
			StartCoroutine("Tara");
		}
		if (CrossPlatformInputManager.GetButtonUp ("Fire1")) {
			Debug.Log ("GetButtonUp");
			StopCoroutine("Tara");
		}
	}

	IEnumerator Tara () {
		while (true) {
			Debug.Log ("Dan");
			Instantiate(mermi, transform.position, Quaternion.identity);

			yield return new WaitForSeconds(mermiAraligi);
		}
	}
}
