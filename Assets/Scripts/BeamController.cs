using System.Collections;
using System.Collections.Generic;
using Cinemachine.Examples;
using UnityEngine;

public class BeamController : MonoBehaviour
{

    public BeamStretch beamStretch;
    public bool isOn;
    
    void Start () {
        //Cursor.visible = false;

        beamStretch = GameObject.Find("Player").GetComponent<BeamStretch>();
    }
	
	void Update () {
		if (isOn == true)
		{
			Vector3 mousePos = GameObject.Find("VirtualMouse").transform.position;
			mousePos -= transform.position;
			Vector3 euler = transform.eulerAngles;
			euler.z = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
			transform.eulerAngles = euler;
		}

		if (Input.GetMouseButtonDown(1)) {
            //toggle light on/off
            //GetComponent<SpriteRenderer>().enabled = !GetComponent<SpriteRenderer>().enabled;
            //GetComponent<SpriteMask>().enabled = !GetComponent<SpriteMask>().enabled;

            isOn = !isOn;

            //beamStretch.enabled = !beamStretch.enabled;

        }
	    
		GetComponent<SpriteRenderer>().enabled = isOn;
		GetComponent<SpriteMask>().enabled = isOn;
		this.GetComponent<Collider2D>().enabled = isOn;
	}
}
