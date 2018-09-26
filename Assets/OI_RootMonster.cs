using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OI_RootMonster : MonoBehaviour {
    public Animator MonsterAnimator;
    bool inAtkRange = false;
    bool isLitUp = false;
    private float fearTimer = 0;
    public float maxFearDuration;


    void Start () {
        
	}
	

	void Update () {
        if(inAtkRange == false && isLitUp == false) {
            MonsterAnimator.SetBool("isWalking", true);
            //moves toward player
        }
        
        if(inAtkRange == true) {
            //monster stops moving
            //freezes player
            MonsterAnimator.SetBool("isWalking", false);
            MonsterAnimator.SetBool("isAttacking", true);   
        }

        //if islitup and run away for maxfearduration
        if(isLitUp == true) {
            fearTimer += Time.deltaTime;
        }
        //if ran away > maxfearduration and no longer collided with mimlight, then feartimer resets
        if(fearTimer >= maxFearDuration) {
            fearTimer = 0;
            isLitUp = false;
        }
    }

}
