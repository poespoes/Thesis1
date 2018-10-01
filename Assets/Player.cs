using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    
    public float moveSpeed;
    float targetPos;
    public float stopPosX;
    public float BufferDistance;
    public bool isWalking;
    public float WalkingState;
    public bool canWalk;
    public GameObject v_Mouse;

    private GameObject blackout;
    public Animator playerAnimator;
    

    void Start() {
        targetPos = transform.position.x;
        WalkingState = this.GetComponent<PlayerAnimation>().WalkingState;
        canWalk = true;
        
        v_Mouse = GameObject.Find("VirtualMouse");
        blackout = GameObject.Find("BlackoutPanel");

        playerAnimator = this.GetComponent<Animator>();
    }

    void Update() {
        if (canWalk == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isWalking = true;
                this.GetComponent<PlayerAnimation>().WalkingState = 1;
                //targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - BufferDistance;
                
                targetPos = v_Mouse.transform.position.x - BufferDistance;
                //Debug.Log("Moving to" + targetPos);
            }

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                isWalking = true;
                this.GetComponent<PlayerAnimation>().WalkingState = 1;
                
                targetPos = (this.transform.position.x + Input.GetAxis("Horizontal"));
                //Debug.Log("Moving to" + targetPos);
                
                playerAnimator.SetBool("MimIsWalking",true);
            }
            else
            {
                playerAnimator.SetBool("MimIsWalking",false);
            }

        }

        if (canWalk == true) {
            float posX = transform.position.x;
            posX = Mathf.MoveTowards(posX, targetPos, moveSpeed * Time.deltaTime);
            transform.position = new Vector3(posX, transform.position.y);
        }

        if(canWalk == false) {
            Debug.Log("canWalk = false");
            //blackout.GetComponent<Canvas>().sortingOrder = 99;
            //blackout.GetComponent<Image>().CrossFadeAlpha(255, 2.0f, false);
            //transform.position = new Vector3(transform.position.x, transform.position.y);
            //this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            
        }
        //Mim trips
        /*if (transform.position.x >= stopPosX) {
            Destroy(gameObject);
            //tell the other animator to play the falldown animation

        }*/


        if (transform.position.x == targetPos) {
            //WalkingState = 0;

            this.GetComponent<PlayerAnimation>().WalkingState = 0;
            //Debug.Log("stop walking");
        }
    }

    public void Say() {
        Debug.Log("trytguhinuj");
    }

   /* private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Tripping") {
            Debug.Log("tripping");

            GameObject trip = GameObject.Find("TripAnimation");
            trip.GetComponent<Animate>().tripping = true;
            //Destroy(gameObject);
            this.transform.position = new Vector2(136.4f, -10.5f);
            this.gameObject.SetActive(false);
        }
    }*/
}
