using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class SelectTarget : MonoBehaviour {

	public GameObject target;
	public GameObject journalist;
	public GameObject artist;
	public GameObject patron;
	public GameObject tourist;
	public GameObject sharktank;
	public ParticleSystem hitEffect;
	public GameObject killEffect;
	public float timeToSelect = 3.0f;
	public int score;
	private float countDown;
	private AudioSource audioSource;
	public Text uiText;
//	AudioClip artistsound[];
	public AudioClip artist1;
	public AudioClip artist2;
	public AudioClip artist3;
	public AudioClip artist4;
	public AudioClip artist5;
	public AudioClip artist6;
	public AudioClip journalist1;
	public AudioClip journalist2;
	public AudioClip journalist3;
	public AudioClip journalist4;
	public AudioClip journalist5;
	public AudioClip patron1;
	public AudioClip patron2;
	public AudioClip patron3;
	public AudioClip patron4;
	public AudioClip patron5;
	public AudioClip patron6;
	public AudioClip tourist1;
	public AudioClip tourist2;
	public AudioClip tourist3;
	public AudioClip tourist4;
	public AudioClip tourist5;
	public AudioClip shark1;
	public AudioClip shark2;
	public AudioSource efxSource;
	
	void Start () {
		score = 0;
		countDown = timeToSelect;
		hitEffect.enableEmission = false;
		uiText.text = "Try on a hat";

//		artistsound =  new AudioClip[]{(AudioClip)Resources.Load("Sound/artist1"),
//			(AudioClip)Resources.Load("Sound/artist2"), 
//			(AudioClip)Resources.Load("Sound/artist3"))};



	}



	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray = new Ray (camera.position, camera.rotation * Vector3.forward);
	
//			hitEffect.transform.position = hit.point;
//			hitEffect.enableEmission = true;
//
//			if (Input.anyKeyDown){
//				//selection feedback - particles change color?
//				audio.Play();
//			}

			RaycastHit hit;
			uiText.text = "Try on a hat";

			if (Physics.Raycast (ray, out hit) && (hit.collider.tag
			                                       == "hat")) {
			hitEffect.transform.position = hit.point;
			hitEffect.enableEmission = true;

			//input bools
			//Cardboard.SDK.Triggered
			//Input.anyKeyDown

			if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject
			                                       == journalist)) {
				uiText.text = "The Art Critic";

				if (Input.anyKeyDown) {					
				//if (Cardboard.SDK.Triggered) {					
//					audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
//					audioSource.Play ();
					SoundManager.instance.RandomizeSfx(journalist1,journalist2,journalist3,journalist4,journalist5);
				}
			}
			else if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject
			                                       == artist)) {
				uiText.text = "The Artist";
				if (Input.anyKeyDown) {					
				//if (Cardboard.SDK.Triggered) {					
					//audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
					//audioSource.Play ();
					SoundManager.instance.RandomizeSfx(artist1,artist2,artist3,artist4,artist5,artist6);
				}
			}
			else if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject
			                                       == tourist)) {
				uiText.text = "The Public";
				if (Input.anyKeyDown) {					
				//if (Cardboard.SDK.Triggered) {					
//					audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
//					audioSource.Play ();
					SoundManager.instance.RandomizeSfx(tourist1,tourist2,tourist3,tourist4,tourist5);
				}
			}
			else if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject
			                                       == patron)) {
				uiText.text = "The Art Collector";
				if (Input.anyKeyDown) {					
				//if (Cardboard.SDK.Triggered) {					
//					audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
//					audioSource.Play ();
					SoundManager.instance.RandomizeSfx(patron1,patron2,patron3,patron4,patron5,patron6);
				}
			}
			else if (Physics.Raycast (ray, out hit) && (hit.collider.gameObject
			                                            == sharktank)) {
				//uiText.text = "The Patron";
				if (Input.anyKeyDown) {					
				//if (Cardboard.SDK.Triggered) {					
					//					audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
					//					audioSource.Play ();
					SoundManager.instance.RandomizeSfx(shark1,shark2);
				}
			}
//			else {
//					// killed
//					Instantiate( killEffect, target.transform.position,
//					            target.transform.rotation );
//					score += 1;
//					countDown = timeToSelect;
//					//SetRandomPosition();
//				}
			} 
//		else {
//				// reset
//				countDown = timeToSelect;
//
//			hitEffect.enableEmission = false;
//		}
	}
//	void SetRandomPosition() {
//		float x = Random.Range (-5.0f, 5.0f);
//		float z = Random.Range (-5.0f, 5.0f);
//		target.transform.position = new Vector3 (x, 0.0f, z);
//	} 
}