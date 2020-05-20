using UnityEngine;
using System.Collections;

public class Oyun : MonoBehaviour {
	public static Oyun instance;
	public int yuksekPuan = 0;
	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy (gameObject);
		}

		if (PlayerPrefs.HasKey ("YuksekSkor")) {
			yuksekPuan = PlayerPrefs.GetInt("YuksekSkor");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
