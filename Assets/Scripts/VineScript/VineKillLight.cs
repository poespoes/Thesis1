﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VineKillLight : MonoBehaviour
{
	public bool canDie;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<Player>().isLIt == true && canDie == true)
		{
			Die();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			canDie = true;
			Debug.Log("Player can Die");
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			canDie = false;
		}
	}

	public void Die()
	{
		GameObject blackout = GameObject.Find("BlackoutPanel");
		blackout.GetComponent<Image>().CrossFadeAlpha(255,5.0f,false);
		Invoke("Restart",2);
		
	
	}
	
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}