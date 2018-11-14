using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLight : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    public Vector3 TargetScale = new Vector3(1f, 1f, 1f);
    public Vector3 StartingScale = new Vector3(5f, 5f, 5f);
    public float TimeToScale = 5.0f;

    public bool isScalingDown;
    private float dimTime = 0.0f;
    private float dimTime2 = 0.0f;

    private Color originalColor;
    public Color darkenedColor;

    public GameObject player;
    public GameObject mimLeaf;
    public GameObject mimLeaf2;
    
    private void Start() {
        player = GameObject.Find("Player");
        mimLeaf = GameObject.Find("MimLeafON");
        mimLeaf2 = GameObject.Find("MimLeafOFF");
        
        transform.localScale = StartingScale;
        //isScalingDown = true;
        originalColor = player.GetComponent<SpriteRenderer>().color;
    }

    private void Update() {
        
        
        if (isScalingDown==true) {
            dimTime += Time.deltaTime / TimeToScale;
            if (dimTime >= 1.0f) {
                transform.localScale = TargetScale;
                isScalingDown = false;
                
                
                

            } else {
                transform.localScale = Vector3.Lerp(StartingScale, TargetScale, dimTime);
                player.GetComponent<SpriteRenderer>().color = originalColor;
                mimLeaf.GetComponent<SpriteRenderer>().color = originalColor;
                mimLeaf2.GetComponent<SpriteRenderer>().color = originalColor;

            }
        }
        else
        {
            dimTime2 += Time.deltaTime / TimeToScale;


            player.GetComponent<SpriteRenderer>().color = darkenedColor;
                mimLeaf.GetComponent<SpriteRenderer>().color = darkenedColor;
                mimLeaf2.GetComponent<SpriteRenderer>().color = darkenedColor;
           
        }

        if (Input.GetButton("Fire1"))
        {
            isScalingDown = false;
            Debug.Log("Light is not shrinking");
            LightOff();
           
            
        }
        else
        {
            isScalingDown = true;
           LightOn();
        }
       
    }

    public void LightOff()
    {
        //put light off script here
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.transform.parent.GetComponent<Player>().isLIt = false;

    }
    
    public void LightOn()
    {
        //put light off script here
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.transform.parent.GetComponent<Player>().isLIt = true;

    }
}

