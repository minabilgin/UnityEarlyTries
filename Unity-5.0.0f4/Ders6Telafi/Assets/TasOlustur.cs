using UnityEngine;
using System.Collections;

public class TasOlustur : MonoBehaviour {
	public GameObject [] tas;
	// Use this for initialization
	float kameraGenislik;

	void Start () {
		kameraGenislik = Camera.main.orthographicSize * Camera.main.aspect;
		StartCoroutine ("TasYarat");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator TasYarat() {
		while (true) {
			Vector3 pozisyon = new Vector3(Random.Range(-kameraGenislik, kameraGenislik),
			                               10f,
			                               -2f);
			Instantiate (tas[Random.Range(0, tas.Length)], pozisyon, Random.rotation);

			yield return new WaitForSeconds(Random.Range (0.2f, 2f));
		}
	}
}
