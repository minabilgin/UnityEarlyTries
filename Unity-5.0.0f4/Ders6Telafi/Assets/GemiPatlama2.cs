﻿using UnityEngine;
using System.Collections;

public class GemiPatlama2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCarpisma(){
		Level.instance.OyunBitti();
	}
}
