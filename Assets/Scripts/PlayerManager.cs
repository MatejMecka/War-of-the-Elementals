using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {
    // Start is called before the first frame update
	public int points;
	GameObject SecondPlayer;
	public Text TextP1;
	public Text TextP2;

	PlayerController PlayerController;


    void Start(){
     	if(this.name == "Player One"){
    		SecondPlayer = GameObject.Find("Player 2");
		}
		if(this.name == "Player 2"){
    		SecondPlayer = GameObject.Find("Player One");
		}

    }

    public void updatePoints(int value){
    	points += value;

    	if(this.name == "Player One"){
			PlayerScores.P1Score += value;
			TextP1.text = "Points: " + points.ToString();
		}

		if(this.name == "Player Two"){
			PlayerScores.P2Score += value;
			TextP2.text = "Points: " + points.ToString();
		}
    }

    IEnumerator Haste(){
    	this.PlayerController.speed = PlayerController.speed * 4;
    	yield return new WaitForSeconds(10);
    	this.PlayerController.speed = PlayerController.speed / 4;
    }

    IEnumerator Slow(){
    	SecondPlayer.GetComponent<PlayerController>().speed = SecondPlayer.GetComponent<PlayerController>().speed / 4;
    	yield return new WaitForSeconds(10);
    	SecondPlayer.GetComponent<PlayerController>().speed = SecondPlayer.GetComponent<PlayerController>().speed * 4;
    }

    IEnumerator DoubleScore(){
    	yield return new WaitForSeconds(5);
    	updatePoints(this.points * 2);
    }



    void OnCollisionEnter2D(Collision2D col)
    {
    	Debug.Log("Hello!");
    	// Handle Elements
    	if(col.gameObject.tag == "Air"){
    		if(this.name == "Player One"){
    			updatePoints(1);
			}
			if(this.name == "Player 2"){
    			updatePoints(-1);
			}
    	}

    	if(col.gameObject.tag == "Fire"){
    		if(this.name == "Player One"){
    			updatePoints(-1);
			}
			if(this.name == "Player 2"){
    			updatePoints(1);
			}
    	}

    	if(col.gameObject.tag == "Ice"){
    		if(this.name == "Player One"){
    			updatePoints(5);
			}
			if(this.name == "Player 2"){
    			updatePoints(-5);
			}
    	}

    	if(col.gameObject.tag == "Lava"){
    		if(this.name == "Player One"){
    			updatePoints(-5);
			}
			if(this.name == "Player 2"){
    			updatePoints(5);
			}
    	}

    	if(col.gameObject.tag == "Player"){
    		SceneManager.LoadScene("Game Over");
    	}

        if(col.gameObject.tag == "Haste"){
            StartCoroutine(Haste());
        }   

        if(col.gameObject.tag == "Lightning"){
            // take points
            SecondPlayer.GetComponent<PlayerManager>().updatePoints(-2);
        }   

        if(col.gameObject.tag == "Slow"){
            // slow down the 
            StartCoroutine(Slow());
        }

        if(col.gameObject.tag == "Fire-Spell"){
            SecondPlayer.GetComponent<PlayerManager>().updatePoints(-2);
        }   

        if(col.gameObject.tag == "Flames"){
            // to implement
            StartCoroutine(DoubleScore());
        }   

        if(col.gameObject.tag == "Lava-Spell"){
            // slow down the 
            StartCoroutine(Slow());
        }   


    }






}
