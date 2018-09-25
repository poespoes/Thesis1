using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {
    public Animator TripAnimator;
    public bool tripping = false;
    public GameObject TrippedMim;
    public GameObject m_player;
    public GameObject trip_camera;

    // Use this for initialization
    void Start () {
        m_player = GameObject.Find("Player");
        trip_camera = GameObject.Find("Trip");
        trip_camera.SetActive(false);
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
        trip_camera.SetActive(true);
        m_player.SetActive(true);
        
     
        Destroy(gameObject);
    }
}
