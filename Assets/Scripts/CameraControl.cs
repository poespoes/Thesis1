using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine.Examples
{
	public class CameraControl : MonoBehaviour
	{
		public CinemachineVirtualCamera focusedCamera;
		public int mainPriority; 

		// Use this for initialization
		void Start()
		{
			
		}

		// Update is called once per frame
		void Update()
		{
			mainPriority = focusedCamera.m_Priority;
		}


	}
}