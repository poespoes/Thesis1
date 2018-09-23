using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cinemachine.Examples {
    public class BeamStretch : MonoBehaviour {

        public CinemachineVirtualCamera cineVCam;
        public GameObject lightBeam;
        public float lightFactor;


        // Use this for initialization
        void Start() {
            cineVCam = GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();
            lightBeam = this.transform.Find("MimLight").gameObject;
            lightFactor = 200;

        }

        // Update is called once per frame
        void Update() {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 thisPos = this.transform.position;

            float distance = Vector3.Distance(mousePos, thisPos);

            //if (Input.GetMouseButtonDown(1)) {

            Debug.Log("The distance is " + distance);

            float distanceFactor = distance / lightFactor;

            lightBeam.transform.localScale = new Vector3(distanceFactor, 1, 1);

            cineVCam.m_Lens.OrthographicSize = 10 + (distanceFactor * 20);



            //}
        }
    }
}