using UnityEngine;
using System.Collections;

public class YenidenOynaButonu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void YenidenOyna () {
		//Debug.Log ("butona basıldı");
		Application.LoadLevel (Application.loadedLevel);
	}
}
