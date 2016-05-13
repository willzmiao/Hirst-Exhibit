using UnityEngine;
using System.Collections;

public class RotatorSlow : MonoBehaviour {


	void Update () 
	{
		transform.Rotate (new Vector3 (0, 10, 0) * Time.deltaTime);
		//transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);

	}
}