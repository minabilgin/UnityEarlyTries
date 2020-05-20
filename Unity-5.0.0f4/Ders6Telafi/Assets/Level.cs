using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public static Level instance ;
	public int puan;
	public GameObject oyunBittiPaneli;
	public GameObject yuksekScorYazisi;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OyunBitti(){
		oyunBittiPaneli.SetActive (true);
		if (puan > Oyun.instance.yuksekPuan) {
			yuksekScorYazisi.SetActive(true);
			Oyun.instance.yuksekPuan= puan;
			PlayerPrefs.SetInt("YuksekSkor",puan);
		}
	}
}
