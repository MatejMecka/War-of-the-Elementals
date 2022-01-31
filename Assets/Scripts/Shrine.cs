using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrine : MonoBehaviour
{
    // Start is called before the first frame update
	public float timeDuration;
	public GameObject ShrineObject;
	private float timer;

    void Start(){
     ShrineObject.SetActive(false);   
    }

    // Update is called once per frame
    void Update(){
      timer += Time.deltaTime;
     if(timer >= timeDuration){
     	ShrineObject.SetActive(true);
     }   
    }

}
