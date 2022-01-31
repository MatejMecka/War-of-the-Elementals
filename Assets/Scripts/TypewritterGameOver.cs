using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypewritterGameOver : MonoBehaviour
{
    public Text txt;
	public string story;
	public float secs = 0.125f;

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

		
	}
}
