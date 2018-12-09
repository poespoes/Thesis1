﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Cinemachine.Examples
{
	public class cinematicCameraTween : MonoBehaviour
	{

		public Transform camPos1;
		public Transform camPos2;

		public Vector3 posA;
		public Vector3 posB;
		
		public float time;

		// Use this for initialization
		void Start()
		{
			posA = camPos1.position;
			posB = camPos2.position;
		}

		// Update is called once per frame
		void Update()
		{

		}

		void AtoB()
		{
			camPos1.transform.DOMove(posB, time);
		}

		void BtoA()
		{
			camPos1.transform.DOMove(posA, time);
		}


	}
}