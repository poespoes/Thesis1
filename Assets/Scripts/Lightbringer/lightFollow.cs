using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFollow : MonoBehaviour {
	
	public GameObject light = GameObject.Find("MimLight");

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = light.transform.position;
		this.transform.rotation = light.transform.rotation;
	}
}
