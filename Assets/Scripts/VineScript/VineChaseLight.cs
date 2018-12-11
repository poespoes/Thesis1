using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class VineChaseLight : MonoBehaviour
{
	public bool inRange;
	public bool isLit;
	public bool noLeaf;

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

		noLeaf = GameObject.Find("Player").GetComponent<Player>().noLeaf;
		
		isLit = GameObject.Find("Player").GetComponent<Player>().isLIt;

		if (inRange == true && isLit == true && noLeaf == false)
		{
			this.transform.DOMove(destination.transform.position, time);
		}
		
		
	}
}
