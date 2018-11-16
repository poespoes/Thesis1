using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		float posX = GameObject.Find("CheckPointManager").GetComponent<GameSingleTon>().lastCheckPoint.x;
		float posY = GameObject.Find("CheckPointManager").GetComponent<GameSingleTon>().lastCheckPoint.y;
		
		this.transform.position = new Vector3(posX, posY, this.transform.position.z);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
