using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
    public Animator PlayerAnimator;
    private SpriteRenderer sr;
    public float WalkingState = 0;
    
    

    // Use this for initialization
    void Start() {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        if (WalkingState == 0) {
            PlayerAnimator.SetBool("MimWalk", false);
            PlayerAnimator.SetBool("MimScareWalk", false);
            PlayerAnimator.SetBool("MimVeryScareWalk", false);
        }
        if (WalkingState == 1 && this.GetComponent<Player>().isWalking == true) {
            PlayerAnimator.SetBool("MimWalk", true);
            PlayerAnimator.SetBool("MimScareWalk", false);
            PlayerAnimator.SetBool("MimVeryScareWalk", false);
        }
        if (WalkingState == 2 && this.GetComponent<Player>().isWalking == true) {
            PlayerAnimator.SetBool("MimWalk", false);
            PlayerAnimator.SetBool("MimScareWalk", true);
            PlayerAnimator.SetBool("MimVeryScareWalk", false);
        }
        if (WalkingState == 3 && this.GetComponent<Player>().isWalking == true) {
            PlayerAnimator.SetBool("MimWalk", false);
            PlayerAnimator.SetBool("MimScareWalk", false);
            PlayerAnimator.SetBool("MimVeryScareWalk", true);
        }
        if (WalkingState == 4 && this.GetComponent<Player>().isWalking == true) {
            PlayerAnimator.SetBool("MimWalk", false);
            PlayerAnimator.SetBool("MimScareWalk", false);
            PlayerAnimator.SetBool("MimVeryScareWalk", false);
            PlayerAnimator.SetBool("MimJumping",true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        //collide fearstate2
        
        if (collision.gameObject.tag == "FearState3") {
            Debug.Log("Walking State = 3");
            WalkingState = 3;
        } else {
            if (collision.gameObject.tag == "FearState2") {
                Debug.Log("Walking State = 2");
                WalkingState = 2;
            }
        }
    }

        private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "FearState2" || collision.gameObject.tag == "FearState3") {
            Debug.Log("Walking State = 1");
            WalkingState = 1;
        }
    }

}
