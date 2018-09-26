using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine.Examples
{
	public class refocusCamera : MonoBehaviour
	{

		public CinemachineVirtualCamera camera;
		public int priority;
		public CameraControl cameraControl;
		
		public GameObject mainCamera;
		public CinemachineBrain cameraBrain;
		
		// Use this for initialization
		void Start()
		{
			cameraControl = GameObject.Find("GameManager").GetComponent<CameraControl>();
			priority = camera.m_Priority;
			
			mainCamera = GameObject.Find("Main Camera");
			cameraBrain = mainCamera.GetComponent<CinemachineBrain>();
		}

		// Update is called once per frame
		void Update()
		{

		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			cameraBrain.m_DefaultBlend.m_Time = 4.0f;
			
			Debug.Log("Collision happened");
			if (collision.gameObject.tag == "Player")
			{
				priority = cameraControl.mainPriority + 1;
				camera.m_Priority = priority;
				cameraControl.focusedCamera = camera;
				Debug.Log("COLLIDED WITH PLAYER");
				
			}
		}
	}
}
