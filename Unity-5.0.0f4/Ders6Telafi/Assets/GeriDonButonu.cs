using UnityEngine;
using System.Collections;

public class GeriDonButonu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GeriDon () {
		//Debug.Log ("butona basıldı");
		Application.LoadLevel ("AnaMenu");
	}
}
