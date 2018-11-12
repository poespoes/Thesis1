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

    private void Start() {
        transform.localScale = StartingScale;
        //isScalingDown = true;
    }

    private void Update() {
        if (isScalingDown==true) {
            dimTime += Time.deltaTime / TimeToScale;
            if (dimTime >= 1.0f) {
                transform.localScale = TargetScale;
                isScalingDown = false;
            } else {
                transform.localScale = Vector3.Lerp(StartingScale, TargetScale, dimTime);
            }
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

