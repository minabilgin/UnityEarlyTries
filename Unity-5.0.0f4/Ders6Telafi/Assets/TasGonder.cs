using UnityEngine;
using System.Collections;

public class TasGonder : MonoBehaviour {
	Rigidbody rb;
	public float tasHizi = 10f;
	public float maxDonmeHizi = 10f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0f, -tasHizi, 0f);
		rb.angularVelocity = Random.insideUnitSphere * maxDonmeHizi;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
