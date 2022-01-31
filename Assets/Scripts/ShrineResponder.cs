using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShrineResponder : MonoBehaviour
{
    // Start is called before the first frame update
	public Text SpellName;
    public Sprite DeactivatedSprite;
    public Sprite ActivatedSprite;
    public SpriteRenderer spriteRenderer;
    public int waitTime=5;


    void Start()
    {
        SpellName.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator HideText(){
    	yield return new WaitForSeconds(waitTime);
    	SpellName.text = "";
        spriteRenderer.sprite = DeactivatedSprite; 
        this.gameObject.tag = "Untagged";
    }

    void OnCollisionEnter2D(Collision2D col){
    	int ind = 0;
    	string[] spells = new string[3];

    	if(col.gameObject.name == "Player One"){
    		spells[0] = "Haste";
    		spells[1] = "Lightning";
    		spells[2] = "Slow";
		}
		if(col.gameObject.name == "Player 2"){
			spells[0] = "Fire-Sppell";
    		spells[1] = "Flames";
    		spells[2] = "Lava-Spell";
		}
		Debug.Log(spells);

		ind = Random.Range (0, spells.Length);
		string spell = spells[ind];
		SpellName.text = spell;
        spriteRenderer.sprite = ActivatedSprite; 
        this.gameObject.tag = spell;




		StartCoroutine(HideText());

		

    }


}
