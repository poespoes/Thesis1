using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkenScene : MonoBehaviour
{
	public Player player;
	private bool isLit;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		isLit = player.isLIt;
		SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();

		if (isLit == false)
		{


			for (int i = 0; i < sprites.Length; i++)
			{
				sprites[i].color = Color.black;
			}
		}
		else
		{
			for (int i = 0; i < sprites.Length; i++)
			{
				sprites[i].color = Color.white;
			}
		}
	}
}
