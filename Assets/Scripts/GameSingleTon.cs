using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleTon : MonoBehaviour
{

	private GameSingleTon instance;
	public Vector2 lastCheckPoint;
	public Vector2 initialCheckPoint;

	// Use this for initialization
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(instance);
		}
		else
		{
			Destroy(gameObject);
		}

		lastCheckPoint = initialCheckPoint;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
