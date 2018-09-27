using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vineAttack : MonoBehaviour {

	public Animator vineAnimator;

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
			}
		}
	}
}
