using UnityEngine;
using System.Collections;

public class TasPatlat : MonoBehaviour {
	public GameObject patlama;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Tas") {
			//yok et
			Level.instance.puan = Level.instance.puan +100;
			Instantiate (patlama, other.transform.position, Quaternion.identity);
			Destroy (other.gameObject); //çarptığımız nesne yani taş
			Destroy (gameObject); // kendimiz yani mermi
		}
	}
}
