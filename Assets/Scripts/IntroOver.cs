using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroOver : MonoBehaviour
{
    public void IntroEnded(){
    	SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
