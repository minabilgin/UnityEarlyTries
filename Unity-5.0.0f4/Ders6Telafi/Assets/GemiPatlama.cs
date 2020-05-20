using UnityEngine;
using System.Collections;

public class GemiPatlama : MonoBehaviour {
	public GameObject patlama;
	public GameObject oyunBittiPaneli;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Tas") {
			oyunBittiPaneli.SetActive(true);
			Instantiate (patlama, transform.position, Quaternion.identity);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}

}
