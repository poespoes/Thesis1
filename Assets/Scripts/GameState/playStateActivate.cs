using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class playStateActivate : MonoBehaviour {
	
	public PlayableDirector director;

	// Use this for initialization
	void Start ()
	{
		director = this.GetComponent<PlayableDirector>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log("This clip is " + director.state);

		String playableState = director.state.ToString();

		if (playableState == "Paused")
		{
			Debug.Log("It has stopped playing DO THE THING");
		}

	}
}
