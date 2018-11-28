using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{

	public Transform grabPos;
	
	// Use this for initialization
	void Start ()
	{
		grabPos = this.transform.GetChild(0).transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
