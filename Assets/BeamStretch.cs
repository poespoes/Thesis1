using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cinemachine.Examples {
    public class BeamStretch : MonoBehaviour {

        public CinemachineVirtualCamera cineVCam;
        public GameObject lightBeam;
        public float lightFactor;
        float originalOrtho;


        // Use this for initialization
        void Start() {
            cineVCam = GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();
            lightBeam = this.transform.Find("MimLight").gameObject;
            //lightFactor = 200;
            originalOrtho = cineVCam.m_Lens.OrthographicSize;
            

        }

        // Update is called once per frame
        void Update() {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 thisPos = this.transform.position;
            
            GameObject v_Mouse = GameObject.Find("VirtualMouse");


            float height = v_Mouse.transform.position.y - thisPos.y;
       

            float distance = Vector3.Distance(v_Mouse.transform.position, thisPos);

            //if (Input.GetMouseButtonDown(1)) {

            //Debug.Log("The distance is " + distance);

            float distanceFactor = distance / lightFactor;

            lightBeam.transform.localScale = new Vector3(distanceFactor, 1, 1);

            if (lightBeam.transform.localScale.x > 1.35f)
            {
                lightBeam.transform.localScale = new Vector3(1.35f,1,1);
            }
            
            cineVCam.m_Lens.OrthographicSize = originalOrtho + (distanceFactor * 10);

            if (cineVCam.m_Lens.OrthographicSize < originalOrtho)
            {
                cineVCam.m_Lens.OrthographicSize = originalOrtho;
            }
            else if(cineVCam.m_Lens.OrthographicSize > 24.5f)
            {
                cineVCam.m_Lens.OrthographicSize = 24.5f;
            }


           

            //}
        }
    }
}