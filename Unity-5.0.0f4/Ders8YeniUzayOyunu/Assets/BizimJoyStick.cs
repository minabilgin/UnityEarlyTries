using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BizimJoyStick : MonoBehaviour,IPointerUpHandler,IDragHandler,IPointerDownHandler {
// dokunmatik ekran için:
// up elini kaldırdığında, drag basılı tutulduğu sırada, down basıldığında

	int hangiParmak;
	bool tasiniyormu = false;
	Vector2 ilkPozisyon; //joystiğin ilk pozisyonu
	public float alanYaricapi = 100f ;

	// Use this for initialization
	void Start () {
		ilkPozisyon = transform.position; //joystiğin ilk pozisyonunu tanımladım. neredeyse o nokta
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!tasiniyormu) {
			//transform.position = ilkPozisyon;//animasyonsuz
			transform.position = Vector3.Lerp (transform.position, ilkPozisyon, 10f * Time.deltaTime); //animasyonlu // linear interpolation(doğrusal ara nokta bulmak)//time.delta time : son iki kare arasındaki zaman farkı
		} 
			Vector2 yeniFarkVektoru = (Vector2)transform.position - ilkPozisyon;
			Vector2 eksenler = yeniFarkVektoru/alanYaricapi; 
			BizimInput.horizontal = eksenler.x;
			BizimInput.vertical = eksenler.y;


	}


// // // basma komutlarını kontrol ediyor
	public void OnPointerDown (PointerEventData data) { //basmayla ilgili özellikleri veriyor //data dediği şey. basan parmak hakkındaki bilgileri veriyor
		if (!tasiniyormu) {
			hangiParmak = data.pointerId;
			tasiniyormu = true;
		}
		Debug.Log ("dokundu");
	}
	public void OnDrag (PointerEventData data) { //sürüklemeyle ilgili özellikleri veriyor/data dediği şey. basan parmak hakkındaki bilgileri veriyor
		if (tasiniyormu && data.pointerId == hangiParmak) {
			Debug.Log(data.position);
			Vector2 farkVektoru = (data.position - ilkPozisyon);
			Vector2 dogrultu = farkVektoru.normalized;
			float uzunluk = farkVektoru.magnitude;
			uzunluk = Mathf.Min(uzunluk, alanYaricapi);

			Vector2 yeniFarkVektoru = uzunluk * dogrultu;

			transform.position = ilkPozisyon + yeniFarkVektoru;
		}
		Debug.Log ("sürükledin");
	}
	public void OnPointerUp (PointerEventData data) { //elini çekmeyle ilgili özellikleri veriyor //data dediği şey. basan parmak hakkındaki bilgileri veriyor
		if (data.pointerId == hangiParmak) {
			tasiniyormu = false;
			//transform.position =ilkPozisyon;
		}
		Debug.Log ("bıraktın");						  
	}
// // //


}
