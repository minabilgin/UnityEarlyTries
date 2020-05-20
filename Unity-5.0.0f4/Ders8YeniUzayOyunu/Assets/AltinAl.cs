using UnityEngine;
using System.Collections;

public class AltinAl : MonoBehaviour {
	public static int puan = 0;

	
	// Use this for initialization
	void Start () {
		//
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter (Collider other){ //enter=girdiği an, stay=kaldığı sıra, exit=çıktığı an. ÇALIŞACAK
		Debug.Log ("TriggerEnter olayı gerçekleşti"); //birşey altına çarptı
		if(other.gameObject.tag == "UzayGemisi"){
			puan = puan + 200;
			Debug.Log(puan);
			Destroy (gameObject);
		}
	}
}
