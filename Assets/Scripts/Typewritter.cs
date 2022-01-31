using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Typewritter : MonoBehaviour
{
    public Text txt;
	public string story;
	public GameObject GameController;
	public float secs = 0.125f;
	private bool finished = false;

	void Start(){
		GameController.SetActive(false);
	}

	void Awake () 
	{
		startNewText();
	}

	public void startNewText(int count = 0){
		story = txt.text;
		txt.text = "";
		StartCoroutine (PlayText(count));
	}


	IEnumerator PlayText(int count = 0){
		foreach (char c in story) {
			txt.text += c;
			yield return new WaitForSeconds (secs);
		}
		yield return new WaitForSeconds (3);

		if(txt.text == story){
			Debug.Log("STORY WWRITTEN");
			finished = true;
		}

		if(count == 1 && finished){
			Debug.Log("PLAYING SCENE");
			SceneManager.LoadScene("Get Ready", LoadSceneMode.Single);
		}

		if(count == 2 && finished){
			Debug.Log("PLAYING SCENE 2");
			SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
		}

		GameController.SetActive(true);
		txt.text = "";
	}
}
