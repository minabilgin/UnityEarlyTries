using UnityEngine;
using System.Collections;

public class OyunaBasla : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Baslat(){
		Debug.Log ("Başlat metodu çalıştı");
		Application.LoadLevel ("Ders7");
	}
}
