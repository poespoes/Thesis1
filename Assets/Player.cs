﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    float targetPos;
    public float stopPosX;
    public float BufferDistance;
    public bool isWalking;
    private float WalkingState;

	void Start () {
        targetPos = transform.position.x;
        WalkingState = this.GetComponent<PlayerAnimation>().WalkingState;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            isWalking = true;
            this.GetComponent<PlayerAnimation>().WalkingState = 1;
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - BufferDistance;
        }

        float posX = transform.position.x;
        posX = Mathf.MoveTowards(posX, targetPos, moveSpeed * Time.deltaTime);
        transform.position = new Vector3(posX, transform.position.y);

        if (transform.position.x >= stopPosX) {
            Destroy(gameObject);
        }
            

        if(transform.position.x == targetPos) {
            //WalkingState = 0;

            this.GetComponent<PlayerAnimation>().WalkingState=0;
            //Debug.Log("stop walking");
        }
	}

    public void Say() {
        Debug.Log("trytguhinuj");
    }
}
