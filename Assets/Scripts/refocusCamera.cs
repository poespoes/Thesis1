﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine.Examples
{
	public class refocusCamera : MonoBehaviour
	{

		public CinemachineVirtualCamera camera;
		public float priority;
		public CameraControl cameraControl;
		
		// Use this for initialization
		void Start()
		{
			cameraControl = GameObject.Find("GameManager").GetComponent<CameraControl>();
			priority = camera.m_Priority;
		}

		// Update is called once per frame
		void Update()
		{

		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			Debug.Log("Collision happened");
			if (collision.gameObject.tag == "Player")
			{
				priority = cameraControl.mainPriority + 1;
				cameraControl.focusedCamera = camera;
				Debug.Log("COLLIDED WITH PLAYER");
				
			}
		}
	}
}
