using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate : MonoBehaviour {
    public Animator TripAnimator;
    public bool tripping = false;
    public GameObject TrippedMim;
    public GameObject m_player;
   
    public GameObject trip_camera2;
    public GameObject blackout;

    // Use this for initialization
    void Start () {
        m_player = GameObject.Find("Player");
        
        trip_camera2 = GameObject.Find("Trip2");

        blackout = GameObject.Find("BlackoutPanel");
        
        
        trip_camera2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (tripping == true) {
            Debug.Log("tripping");
            TripAnimator.SetBool("MimTrip", true);
        }

    }
    void spawnTrippedMim() {
        //TrippedMim.SetActive(true);
       
        m_player.SetActive(true);
        
     
        Destroy(gameObject);
    }

    void cameraActivate()
    {
        //trip_camera2.SetActive(true);
    }

    void fadeOut()
    {
        //GameObject.Find("BlackoutPanel").GetComponent<UICrossFade>().willFadeOut = true;
        Debug.Log("BlackoutSent");
        
        blackout.GetComponent<Image>().CrossFadeAlpha(255,4,false);

        //blackout.GetComponent<UICrossFade>().willFadeOut=true;
    }
}
