using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    float targetPos;
    public float stopPosX;
    public float BufferDistance;

	void Start () {
        targetPos = transform.position.x;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - BufferDistance;
        }

        float posX = transform.position.x;
        posX = Mathf.MoveTowards(posX, targetPos, moveSpeed * Time.deltaTime);
        transform.position = new Vector3(posX, transform.position.y);

        if (transform.position.x >= stopPosX)
            Destroy(gameObject);
	}

    public void Say() {
        Debug.Log("trytguhinuj");
    }
}
