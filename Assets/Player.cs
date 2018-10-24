using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    
    public float moveSpeed;
    public float jumpAmount;
    float targetPos;
    public float stopPosX;
    public float BufferDistance;
    public bool isWalking;
    public float WalkingState;
    public bool canWalk;
    public GameObject v_Mouse;

    private GameObject blackout;
    public Animator playerAnimator;

    private float velocityX;
    private float velocityY;

    public bool canJump;

    public float playerScaredSpeed;
    public float playerVeryScaredSpeed;


    public bool canClimb;
    public bool isClimbing;

    void Start() {
        targetPos = transform.position.x;
        WalkingState = this.GetComponent<PlayerAnimation>().WalkingState;
        canWalk = true;
        
        v_Mouse = GameObject.Find("VirtualMouse");
        blackout = GameObject.Find("BlackoutPanel");

        playerAnimator = this.GetComponent<Animator>();
    }
    
    void Update() {
   if (Input.GetKeyDown(KeyCode.G)) {
            canJump = true;
        }
        
        if (canWalk == true)
        {
            
            
            /*
            if (Input.GetMouseButtonDown(0))
            {
                isWalking = true;
                this.GetComponent<PlayerAnimation>().WalkingState = 1;
                //targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - BufferDistance;
                
                targetPos = v_Mouse.transform.position.x - BufferDistance;
                //Debug.Log("Moving to" + targetPos);
            }
            */

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                isWalking = true;
                this.GetComponent<PlayerAnimation>().WalkingState = 1;
                
                targetPos = (this.transform.position.x + Input.GetAxis("Horizontal"));
                //Debug.Log("Moving to" + targetPos);
                
                playerAnimator.SetBool("MimIsWalking",true);
                Debug.Log("Is Walking");
                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    this.GetComponent<SpriteRenderer>().flipX = false;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().flipX = true;
                }
            }
            else
            {
                playerAnimator.SetBool("MimIsWalking",false);
                Debug.Log("Not Walking");
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
            Debug.Log("stop walking");
        }

        velocityY = this.GetComponent<Rigidbody2D>().velocity.y;
       
        /*if (velocityY == 0)
        {
            
            canJump = true;
        }
        else
        {
            Debug.Log("I CANNOT JUMP");
            canJump = false;
            playerAnimator.SetBool("MimJumping",false);
        }*/


        Vector3 RayCastPoint = new Vector3(transform.position.x, transform.position.y+1,transform.position.z);
        RaycastHit2D hit = Physics2D.Raycast(RayCastPoint, Vector2.down, 1f);
       /* if (hit != null)
        {
            Debug.Log(hit.collider.name);

            if (hit.collider.transform.tag == "ground")
            {
                Debug.Log("Raycast touching ground");

            }
        }*/


        if (Input.GetButtonDown("Jump"))
        {
            if (canJump == true)
            {
                canJump = false;
                //Debug.Log("I CAN JUMP");
                this.GetComponent<Rigidbody2D>().AddForce((Vector2.up)*100*jumpAmount);
                //this.GetComponent<PlayerAnimation>().WalkingState = 4;
                playerAnimator.SetBool("MimJumping",true);

                isClimbing = false;


            }
            else
            {
                //Debug.Log("Can't Jump");
            }
        }

        if (canClimb == true)
        {
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                Debug.Log("The Climb begins");
                isClimbing = true;


            }

            
        }
        else
        {
            isClimbing = false;
        }
        
        if (isClimbing == true)
        {
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,Mathf.Lerp(0, Input.GetAxis("Vertical")* moveSpeed, 0.8f));
                
                /*this.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")* moveSpeed, 0.8f),
                    Mathf.Lerp(0, Input.GetAxis("Vertical")* moveSpeed, 0.8f));*/

            }
            else
            {
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            }

            canJump = true;
        }
        else
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
       
    }

    public void Say() {
        Debug.Log("trytguhinuj");
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided");
        
        Vector2 normal = other.contacts[0].normal;

        if (other.gameObject.tag == "ground" && normal.y > Mathf.Abs(normal.x))
        {
           canJump = true;
           playerAnimator.SetBool("MimJumping",false);
        }
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
