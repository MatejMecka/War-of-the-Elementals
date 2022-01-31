using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ControlGame : MonoBehaviour
{
    // Start is called before the first frame update
	public Text Story;
	public string nextText;
	public Text Countdown;
	public GameObject Player;
	public float Deadline;
	private float timer;
	private bool ran = false;
	


    void Start()
    {
        Story.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    	float diff = Deadline;
    	if(!ran){
	        timer += Time.deltaTime;
	        diff = Deadline-timer;
	    }

        Scene scene = SceneManager.GetActiveScene();
        if(diff <= 0 && !ran){
        	if(scene.name == "Get Ready"){
        		SceneManager.LoadScene("Chasing - Eefret", LoadSceneMode.Single);
        	}
            if(scene.name == "Chasing - Genie"){
                Debug.Log("EXEC");
                nextText = nextText.Replace("XX", PlayerScores.P1Score.ToString());
                Story.text = nextText;
                GameObject.Find("Canvas").GetComponent<Typewritter>().startNewText(1);
            } else {
                Debug.Log("2 EXEC");
                nextText = nextText.Replace("XX", PlayerScores.P2Score.ToString());
                Story.text = nextText;
                GameObject.Find("Canvas").GetComponent<Typewritter>().startNewText(2);
            }

        	Player.SetActive(false);
        	ran = true;
        }
        Countdown.text = Math.Round((decimal)diff).ToString();
    }
}
