using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuanGoster : MonoBehaviour {
	Text text;
	
	
	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Puan :" + AltinAl.puan;																		
		
	}
}

