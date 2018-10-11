using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class AlphaTest : MonoBehaviour {
 
     public Color A = Color.magenta;
     public Color B = Color.blue;
     public float fadeInSpeed = 0.001f;
     public float fadeOutSpeed = 0.001f;
     public float lerpProgress = 0;
 
     SpriteRenderer spriteRenderer;

     private BeamController beamController;
 
     //private Image image;
 
     
     
     void Start() {
         spriteRenderer = GetComponent<SpriteRenderer>();
         //image = GetComponent<Image>();

         beamController = GameObject.Find("MimLight").GetComponent<BeamController>();
     }
 
     void Update() {
         /*if (Input.GetKey(KeyCode.Alpha1)) {
             lerpProgress += 0.01f;
             Debug.Log("Bumping up!");
         }*/
         
         if (beamController.isOn==true) {
             lerpProgress += fadeInSpeed;
             Debug.Log("Bumping up!");

             if (lerpProgress > 1)
             {
                 lerpProgress = 1;
                
             }

             if (lerpProgress > 0.9)
             {
                 GameObject.Find("GameManager").GetComponent<enviromentalDeath>().Die();
                 GameObject.Find("GameManager").GetComponent<gameState>().interactive = false;
             }
         }
         else
         {
             lerpProgress -= fadeOutSpeed;
             if (lerpProgress < 0)
             {
                 lerpProgress = 0;
             }
         }
 
         
         spriteRenderer.color = Color.Lerp(A, B, lerpProgress);
         //image.color = Color.Lerp(A, B, lerpProgress);
     }
 }