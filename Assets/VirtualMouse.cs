using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualMouse : MonoBehaviour {

    Vector3 prevMosuePos;
	public float verticalSpeed;
	public float horizontalSpeed;

    BeamController beamController;
    
	void Start () {
        prevMosuePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

        beamController = GameObject.Find("MimLight").GetComponent<BeamController>();
	}
	
	void Update () {
		float h = horizontalSpeed * Input.GetAxisRaw("Mouse X");
		float v = verticalSpeed * Input.GetAxisRaw("Mouse Y");
		
		transform.position = transform.position + new Vector3(h,v,0);

        //transform.position += Camera.main.ScreenToWorldPoint(Input.mousePosition) - prevMosuePos;
        //prevMosuePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Constraint the position inside the max range
        Vector3 delta = transform.position - beamController.transform.position;
        if (delta.magnitude > beamController.currentBeamRange) {
            transform.position = beamController.transform.position + delta.normalized * beamController.currentBeamRange;
        }
    }
}
