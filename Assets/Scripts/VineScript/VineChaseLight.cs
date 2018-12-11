using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class VineChaseLight : MonoBehaviour
{
	public bool inRange;
	public bool isLit;
	public bool noLeaf;
	public bool interactive;

	public float time;

	public Transform destination;
	
	

	// Use this for initialization
	void Start () {
		if (time == 0)
		{
			time = 5;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		interactive = GameObject.Find("GameManager").GetComponent<gameState>().interactive;
		
		noLeaf = GameObject.Find("Player").GetComponent<Player>().noLeaf;
		
		isLit = GameObject.Find("Player").GetComponent<Player>().isLIt;

		if (inRange == true && isLit == true && noLeaf == false && interactive==true) 
		{
			this.transform.DOMove(destination.transform.position, time);
			Debug.Log("Vine is chasing");
		}
		
		
	}
}
