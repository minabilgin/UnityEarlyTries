using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class UzayGemisiKontrol : MonoBehaviour {
	Rigidbody r;
	public float maksimumHiz = 10f;
	Quaternion aci;
	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
		aci = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");//joystick için
		float y = CrossPlatformInputManager.GetAxis ("Vertical");//joystick için
		//float x = Input.GetAxisRaw ("Horizontal");//normal
		//float y = Input.GetAxisRaw ("Vertical");//normal
		Vector3 hizVektoru = new Vector3 (x, y, 0f);
		r.velocity = hizVektoru * maksimumHiz;
		/*transform.rotation = Quaternion.AngleAxis (y * 30f, new Vector3 (1f, 0f, 0f)) *
							 Quaternion.AngleAxis (x * 30f, new Vector3 (0f, -1f, 0f)) *
							 aci;*/
		transform.rotation = Quaternion.Euler(y * 30f, -x * 30f, 0f ) * aci;



		float kameraYukseklik = Camera.main.orthographicSize;
		float kameraGenislik = Camera.main.orthographicSize * Camera.main.aspect;
		//clamp bir değer veriyorsun. onu min ile max arasında kısıtlıyor
		float yatayPozisyon = Mathf.Clamp (transform.position.x, 
		                                   -kameraGenislik + 1f, 
		                                   kameraGenislik - 1f);
		float dikeyPozisyon = Mathf.Clamp (transform.position.y, 
		                                   -kameraYukseklik + 1f, 
		                                   kameraYukseklik - 1f);
		transform.position = new Vector3 (yatayPozisyon, 
		                                  dikeyPozisyon, 
		                                  transform.position.z );

	}
}
