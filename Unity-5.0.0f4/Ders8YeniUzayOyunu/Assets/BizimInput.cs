using UnityEngine;
using System.Collections;

public class BizimInput : MonoBehaviour {
	public static float horizontal;
	public static float vertical;

	public static float GetAxis(string exenAdi){
		if (exenAdi == "Horizontal") {
			return horizontal;
		} else if (exenAdi == "Vertical") {
			return vertical;
		} else {
			return Input.GetAxis(exenAdi);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
