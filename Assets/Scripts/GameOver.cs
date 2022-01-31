using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
	public Text text;

    void Start()
    {
    	text.text = "Sar-Elam grew bored of your endless chasing. He ended the match for you.";
    	int diff = PlayerScores.P2Score - PlayerScores.P1Score;
        if(PlayerScores.P2Score > PlayerScores.P1Score){
        	text.text += "\nRagnara you have won with " + Math.Abs(diff) + "elementals remaining.";
        }

        if(PlayerScores.P2Score < PlayerScores.P1Score){
        	text.text += "\nSolmyr you have won with " + Math.Abs(diff) + "elementals remaining.";
        }

        if(PlayerScores.P1Score == PlayerScores.P2Score){
        	text.text += "\nIt's a tie...";
        }

        text.text += "\nThe battle is over.";

        GameObject.Find("Canvas").GetComponent<TypewritterGameOver>().startNewText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
