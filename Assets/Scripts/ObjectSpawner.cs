using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
	private string currentElement = "";
	private bool countdownPassed = true;

	public Sprite AirSprite;
	public Sprite FireSprite;
	public Sprite IceSprite;
	public Sprite LavaSprite;
	public Sprite NoneSprite;
	public SpriteRenderer spriteRenderer;

    // Update is called once per frame
    void Update()
    {
        if (currentElement == "" && countdownPassed ){
        	int ind = Random.Range (1, 100);

			if(ind >= 1 && ind <= 40){
				spriteRenderer.sprite = AirSprite; 
				this.gameObject.tag = "Air";
				currentElement = "Air";
			}

			if(ind >= 41 && ind <= 81){
				spriteRenderer.sprite = FireSprite; 
				this.gameObject.tag = "Fire";
				currentElement = "Fire";
			}

			if(ind >= 82 && ind <= 89){
				spriteRenderer.sprite = IceSprite;
				this.gameObject.tag = "Ice";
				currentElement = "Ice";
			}

			if(ind >= 90 && ind <= 100){
				spriteRenderer.sprite = LavaSprite; 
				this.gameObject.tag = "Lava";
				currentElement = "Lava";
			}
        }
    }

    IEnumerator Despawn(){
    	currentElement = "";
    	this.gameObject.tag = "Untagged";
    	spriteRenderer.sprite = NoneSprite;
    	countdownPassed = false;
    	yield return new WaitForSeconds(5);
    	countdownPassed = true;
    }

    void OnCollisionEnter2D(Collision2D col){
    	Debug.Log("Collided with Player!");
    	StartCoroutine(Despawn());
    }

}
