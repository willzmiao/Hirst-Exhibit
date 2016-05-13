using UnityEngine;
using System.Collections;
public class LookTo : MonoBehaviour {

	public GameObject ground;

	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray;
		RaycastHit hit;
		GameObject hitObject;
		Debug.DrawRay (camera.position,
		               camera.rotation * Vector3.forward * 100.0f);
		ray = new Ray (camera.position,
		               camera.rotation * Vector3.forward);

		if (Physics.Raycast (ray, out hit)) {
			hitObject = hit.collider.gameObject;
			transform.position = hit.point; //set cursor loc to raycast hit loc
			//if (hitObject == hats) {
//			if (hitObject == ground) {
//				Debug.Log ("Hit (x,y,z): " + hit.point.ToString("F2"));
//				transform.position = hit.point;
//				//hat disappears
//				//play random audio clip
//
//			}
	
		}
	}
}
