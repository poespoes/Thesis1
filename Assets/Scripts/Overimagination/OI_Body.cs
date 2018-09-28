﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OI_Body : MonoBehaviour {
    public Animator MonsterAnimator;
    bool inAtkRange = false;
    bool isLitUp = false;
    private float fearTimer = 0;
    public float maxFearDuration;
    public float speedPercent;
    private float actualSpeed;

    public GameObject player;
    public GameObject OIMonster;
    private Deathcollider deathCollider;

    // Use this for initialization
    void Start () {
        GameObject.Find("New_OIMonster").GetComponent<Script>().isWalking =
            GameObject.Find("New_OIMonster").GetComponen
        deathCollider = GetComponent<Deathcollider>();
    }
	
	// Update is called once per frame
	void Update () {
        //if LitUp == true
        MonsterAnimator.SetBool("isWalking", true);
        //if LitUp == false
        MonsterAnimator.SetBool("isWalking", true);

        //if DeathCollider is true
        if (deathCollider.deathTriggered == true) {
            Debug.Log("Kill!Kill!");
            player.GetComponent<Player>().canWalk = false;
            MonsterAnimator.SetBool("isWalking", false);
            MonsterAnimator.SetBool("isAttacking", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "MimLight") {
            isLitUp = true;
        }
    }
}
