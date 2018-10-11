using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightDeath : MonoBehaviour
{
	public float timer;
	public float timeRemaining;

	public Image redOutPanel;
	
	// Use this for initialization
	void Start ()
	{
		timeRemaining = timer;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Color tempColor = redOutPanel.color;
		
		//timer = timer - Time.deltaTime;
		//Debug.Log(timer + " seconds remaining");

		if (this.GetComponent<BeamController>().isOn == true)
		{
			timeRemaining = timeRemaining - Time.deltaTime;
			tempColor.a -= Time.deltaTime / timeRemaining;
		}
		else
		{
			if (timeRemaining < timer)
			{
				timeRemaining = timeRemaining + Time.deltaTime;
				tempColor.a += Time.deltaTime / timeRemaining;
			}
		}


		
		//tempColor.a += Time.deltaTime / timer;

	
		redOutPanel.color = tempColor;



		//Debug.Log(timeRemaining + " seconds remaining" );


	}
}