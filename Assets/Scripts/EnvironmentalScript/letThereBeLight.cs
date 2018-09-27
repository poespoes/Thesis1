using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letThereBeLight : MonoBehaviour {
	public GameObject blackout;
	public bool canActivate;
	public bool hasActivated;

	// Use this for initialization
	void Start () {
		
		blackout = GameObject.Find("BlackoutPanel");

		canActivate = false;
		hasActivated = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (canActivate == true & hasActivated == false)
		{
			if (Input.GetMouseButtonDown(1))
			{
				Debug.Log("LET THERE BE LIGHT");
				blackout.GetComponent<Image>().CrossFadeAlpha(0.1f, 10.0f, false);
				hasActivated = false;
			}
		}
	}
}
