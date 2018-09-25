using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualMouse : MonoBehaviour {

    Vector3 prevMosuePos;
    
	void Start () {
        prevMosuePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
	}
	
	void Update () {
        transform.position += Camera.main.ScreenToWorldPoint(Input.mousePosition) - prevMosuePos;
        prevMosuePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
