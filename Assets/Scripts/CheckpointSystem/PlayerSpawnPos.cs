using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPos : MonoBehaviour
{

	private GameSingleTon _gameSingleTon;
	
	// Use this for initialization
	void Start ()
	{

		_gameSingleTon = GameObject.Find("CheckPointSystem").GetComponent<GameSingleTon>();
		this.transform.position = _gameSingleTon.lastCheckPoint; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
