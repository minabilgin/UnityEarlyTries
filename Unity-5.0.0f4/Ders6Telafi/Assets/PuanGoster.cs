﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuanGoster : MonoBehaviour {
	Text txt;


	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Puan: " + Level.instance.puan;
	
	}
}
