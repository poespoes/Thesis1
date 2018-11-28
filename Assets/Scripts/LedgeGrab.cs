using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGrab : MonoBehaviour
{

	public bool canGrab;
	public GameObject ledge;
	public GameObject player;
	

	// Use this for initialization
	void Start ()
	{
		canGrab = false;
		player = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		GrabEdge();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("grabLedge"))
		{
			Debug.Log("Can grab this ledge");
			canGrab = true;

			ledge = other.gameObject;
		}

	}

	private void GrabEdge()
	{
		if (canGrab == true)
		{
			if (player.GetComponent<Player>().canJump == false)
			{
				
				
				player.GetComponent<Animator>().Play("MimLedgeGrab");
				player.GetComponent<PlayerAnimation>().WalkingState = 6;
				
				
				player.transform.position = ledge.GetComponent<Ledge>().grabPos.position;
				player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY|RigidbodyConstraints2D.FreezePositionX|RigidbodyConstraints2D.FreezeRotation;
				GameObject.Find("GameManager").GetComponent<gameState>().interactive = false;

			}
		}
		
	}
}
