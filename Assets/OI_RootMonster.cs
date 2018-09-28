using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OI_RootMonster : MonoBehaviour {
    private float fearTimer = 0;
    public float maxFearDuration;
    public float speedPercent;
    private float actualSpeed;

    public GameObject player;    
    

    void Start () {
        player = GameObject.Find("Player");
        actualSpeed = (speedPercent / 100) * 1;
        
    }


    void Update() {

        //Running to the player
        if (inAtkRange == false && isLitUp == false) {
            transform.position = Vector2.MoveTowards(transform.position,
            new Vector2(player.transform.position.x, transform.position.y), actualSpeed);
        }

        //Running away from the player
        if (isLitUp == true) {
            Debug.Log("Running away!");
            fearTimer += Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(-player.transform.position.x, transform.position.y), actualSpeed);
        }

        //if ran away > maxfearduration and no longer collided with mimlight, then feartimer resets
        if (fearTimer >= maxFearDuration) {
            fearTimer = 0;
            isLitUp = false;
        }
    }



}
