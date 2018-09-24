﻿using System.Collections;
using System.Collections.Generic;
using Cinemachine.Examples;
using UnityEngine;

public class gameState : MonoBehaviour
{
	public bool interactive;
	public BeamStretch beamStretch;
	public BeamController beamController;
	public Player player;	

	// Use this for initialization
	void Start ()
	{
		beamStretch = GameObject.Find("Player").GetComponent<BeamStretch>();
		beamController = GameObject.Find("MimLight").GetComponent<BeamController>();
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		beamStretch.enabled = interactive;
		beamController.enabled = interactive;
		player.enabled = interactive;
	}
}
