using UnityEngine;
using System.Collections;

public class Carpisma : MonoBehaviour {
	public GameObject efekt1;
	public GameObject efekt2;
	public string etiketKontrolu;
	public bool buNesneYokOlsun;
	public bool digerNesneYokOlsun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == etiketKontrolu) {
			SendMessage ("OnCarpisma", SendMessageOptions.DontRequireReceiver );
			if (efekt1){ //bizim nesnemiz patlasın
				Instantiate (efekt1, transform.position, Quaternion.identity);
			}
			if (efekt2){ //diğer nesne patlasın
				Instantiate (efekt2, other.transform.position, Quaternion.identity);
			}
			if (digerNesneYokOlsun){
				Destroy (other.gameObject);

			}
			if(buNesneYokOlsun){
				Destroy (gameObject);
			}
		}
	}
}
