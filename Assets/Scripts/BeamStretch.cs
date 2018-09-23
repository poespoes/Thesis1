using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamStretch : MonoBehaviour {

    public GameObject lightBeam;

	// Use this for initialization
	void Start () {
        lightBeam = this.gameobject.transform.Find("MimLight");


	}
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 thisPos = this.transform.position;

        float distance = Vector3.Distance(mousePos, thisPos);

        if (Input.GetMouseButtonDown(1)) {
            //toggle light on/off
            Debug.log(distance);
           
        }
    }
}
