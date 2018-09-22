using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour {

    void Start () {
        //Cursor.visible = false;
    }
	
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos -= transform.position;
        Vector3 euler = transform.eulerAngles;
        euler.z = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.eulerAngles = euler;

        if (Input.GetMouseButtonDown(1)) {
            //toggle light on/off
            GetComponent<SpriteRenderer>().enabled = !GetComponent<SpriteRenderer>().enabled;
        }
	}
}
