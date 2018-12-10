using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
	private GameObject player;
	private GameObject mimLeaf;
	
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		mimLeaf = GameObject.Find("MimLeaf");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void StartCutscene()
	{
		GameObject.Find("GameManager").GetComponent<gameState>().interactive = false;
		player.GetComponent<PlayerAnimation>().WalkingState = 0;
		player.GetComponent<Player>().isWalking = false;
		player.GetComponent<Animator>().Play("Idle");
		player.GetComponent<SpriteRenderer>().enabled = false;
		mimLeaf.GetComponentInChildren<SpriteRenderer>().enabled = false;



	}

	void EndCutScene()
	{
		GameObject.Find("GameManager").GetComponent<gameState>().interactive = true;
		player.GetComponent<SpriteRenderer>().enabled = true;
		mimLeaf.GetComponentInChildren<SpriteRenderer>().enabled = true;
	}
}
