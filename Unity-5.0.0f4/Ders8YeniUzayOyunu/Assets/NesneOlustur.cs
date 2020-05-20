using UnityEngine;
using System.Collections;

public class NesneOlustur : MonoBehaviour {
	public GameObject nesne;
	
	// Use this for initialization
	void Start () {
		/*for (int i=0; i<25; i++) {
			Vector3 pozisyon = new Vector3(Random.Range (-3f,60f),Random.Range (-5f,2f),0);
			Instantiate (nesne, pozisyon, Quaternion.identity); //kopyasını çıkar
		}*/
		//AltinOlustur (); da olur
		StartCoroutine ("AltinOlustur");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator AltinOlustur(){
		for (int i=0; i<100; i++) {
			Vector3 pozisyon = new Vector3(Random.Range(-10f,10f), Random.Range (-5f,5f),-2);
			GameObject yeniAltin = (GameObject) Instantiate (nesne, pozisyon, Quaternion.identity); //kopyasını çıkar, çıkardığını altin olarak ata
			yield return new WaitForSeconds(Random.Range(1f,5f));
			Destroy(yeniAltin,Random.Range(3f,6f)); // 3 saniye sonra altini yok et
		}


	}
}							
