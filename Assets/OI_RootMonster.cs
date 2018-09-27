using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OI_RootMonster : MonoBehaviour {
    public Animator MonsterAnimator;
    bool inAtkRange = false;
    bool isLitUp = false;
    private float fearTimer = 0;
    public float maxFearDuration;
    public float speedPercent;
    private float actualSpeed;

    public GameObject player;
    private Deathcollider deathCollider;

    void Start () {
        player = GameObject.Find("Player");
        actualSpeed = (speedPercent / 100) * 1;
        deathCollider = GetComponent<Deathcollider>();

    }


    void Update() {
        if (inAtkRange == false && isLitUp == false) {
            MonsterAnimator.SetBool("isWalking", true);
            //moves toward player
            transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(player.transform.position.x, transform.position.y), actualSpeed);

        }

        //MOSTAFA HELPPPPPP~! I dunno what I did wrong. DEATH TRIGGERED in the child script.
        if (deathCollider.deathTriggered == true) {
            Debug.Log("Kill!Kill!");

            //monster stops moving
            //freezes player
            MonsterAnimator.SetBool("isWalking", false);
            MonsterAnimator.SetBool("isAttacking", true);
        }

        //if islitup and run away for maxfearduration
        if (isLitUp == true && inAtkRange == false) {
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

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "MimLight") {
            isLitUp = true;
        }     
    }

}
