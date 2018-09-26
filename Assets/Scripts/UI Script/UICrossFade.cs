using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICrossFade : MonoBehaviour
{
	public GameObject canvas;
	public bool willFadeIn;
	public bool willFadeOut;
	
	// Use this for initialization
	void Start ()
	{
		willFadeIn = false;
		willFadeOut = false;
		
		canvas = this.gameObject;
		
		canvas.GetComponent<Image>().CrossFadeAlpha(0,2.0f,false);
	}
	
	// Update is called once per frame
	void Update () {
		if (willFadeIn = true)
		{
			fadeIn();
			willFadeIn = false;
		}
		
		if (willFadeOut = true)
		{
			fadeIn();
			willFadeOut = false;
		}
	}

	void fadeIn()
	{
		canvas.GetComponent<Image>().CrossFadeAlpha(0,2.0f,false);
	}

	void fadeOut()
	{
		canvas.GetComponent<Image>().CrossFadeAlpha(1,0.2f,false);
		Debug.Log("BlackoutReceived");
	}
}
