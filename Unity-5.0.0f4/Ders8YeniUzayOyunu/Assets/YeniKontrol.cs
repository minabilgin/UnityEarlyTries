using UnityEngine;
using System.Collections;


public class YeniKontrol : MonoBehaviour {
	Rigidbody rigidbody;
	public float hiz;
	public float donmehizi;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//dönmesi
		//float dondurme = Input.GetAxis ("Horizontal"); //joystickiz
		float dondurme = BizimInput.GetAxis ("Horizontal");
		Vector3 donmeEkseni = new Vector3 (0f,0f, dondurme)*donmehizi;
		transform.Rotate(donmeEkseni);

		//ileri gitmesi
		//float ileri = Input.GetAxis ("Vertical");//joysitcksiz
		float ileri = BizimInput.GetAxis ("Vertical");
		rigidbody.AddForce (transform.right*(ileri*hiz));


		float kameraYukseklik = Camera.main.orthographicSize;
		float kameraGenislik = Camera.main.orthographicSize * Camera.main.aspect;
		//clamp bir değer veriyorsun. onu min ile max arasında kısıtlıyor
		float yatayPozisyon = Mathf.Repeat (transform.position.x + kameraGenislik, 
		                                    kameraGenislik + kameraGenislik) - kameraGenislik;
		                                   
		float dikeyPozisyon = Mathf.Repeat (transform.position.y + kameraYukseklik, 
		                                    kameraYukseklik + kameraYukseklik ) - kameraYukseklik ;

		transform.position = new Vector3 (yatayPozisyon, 
		                                  dikeyPozisyon, 
		                                  transform.position.z );


	
	}
}
