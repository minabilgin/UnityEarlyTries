using UnityEngine;
using System.Collections;

public class EksenDeneme : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");
		//float x = Input.GetAxisRaw ("Horizontal");
		//float y = Input.GetAxisRaw ("Vertical");
		Vector3 pozisyon = new Vector3 (x, y, 0f);
		transform.position = pozisyon;
	}
}
