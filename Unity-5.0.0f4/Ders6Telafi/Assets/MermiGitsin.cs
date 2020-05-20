using UnityEngine;
using System.Collections;

public class MermiGitsin : MonoBehaviour {
	Rigidbody rb;
	public float mermiHizi = 10f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0f, mermiHizi, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
