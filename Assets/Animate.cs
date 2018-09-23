using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {
    public Animator TripAnimator;
    public bool tripping = false;
    public GameObject TrippedMim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (tripping == true) {
            Debug.Log("tripping");
            TripAnimator.SetBool("MimTrip", true);
        }

    }
    void spawnTrippedMim() {
        TrippedMim.SetActive(true);
        Destroy(gameObject);
    }
}
