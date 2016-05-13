using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startGame : MonoBehaviour {

	public Button startText;


	// Use this for initialization
	void Start () {
	
		startText = startText.GetComponent<Button> ();
		StartCoroutine(LoadAfterDelay(1));

	}

	IEnumerator LoadAfterDelay(int time){
		yield return new WaitForSeconds(20); 
		Application.LoadLevel(1);
	}
	
//	public void StartLevel()
//	{
//		Application.LoadLevel (1);
//	}
	
}
