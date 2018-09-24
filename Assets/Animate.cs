using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {
    public Animator TripAnimator;
    public bool tripping = false;
    public GameObject TrippedMim;
    public GameObject m_player;

    // Use this for initialization
    void Start () {
        m_player = GameObject.Find("Player");
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
}
