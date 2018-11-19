using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	private GameSingleTon _gameSingleTon;

	// Use this for initialization
	void Start ()
	{
		_gameSingleTon = GameObject.Find("CheckPointSystem").GetComponent<GameSingleTon>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			_gameSingleTon.lastCheckPoint = new Vector2(this.transform.position.x,this.transform.position.y);
			
		}
		
	}
}
