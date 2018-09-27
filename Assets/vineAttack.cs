using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vineAttack : MonoBehaviour {

	public Animator vineAnimator;
    public SpriteRenderer ScreenDark;
   
	public bool canAttack;
	// Use this for initialization
	void Start ()
	{
		canAttack = false;

		vineAnimator = this.GetComponent<Animator>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "MimLight")
		{
			if (canAttack == true)
			{
				Debug.Log("END SCENE");
				vineAnimator.SetBool("isAttacking", true);
				vineAnimator.SetBool("isGlowing", false);
				
				//GameObject blackout = GameObject.Find("BlackoutPanel");
				//blackout.GetComponent<Image>().CrossFadeAlpha(255,5.0f,false);
			}
		}
	}

    void ScreenToDark() {
        ScreenDark.sortingOrder = 99;
    }
}
