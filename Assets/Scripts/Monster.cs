using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public List<Sprite> spriteList;
    public float frameDuration;
    public float frameReverseDuration;
    bool isLightened = false;
    float timer = 0;
    int currentIndex = 0;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        //anim.StartPlayback();
        //anim.recorderMode = AnimatorRecorderMode.Record;
        //Animator.recorderMode != AnimatorRecorderMode.Offline;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            anim.speed =-0.5f;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            anim.speed -= 0.1f;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            anim.speed = 0;

        timer += Time.deltaTime;
        if (isLightened == false) {
            if (timer >= frameDuration) {
                timer -= frameDuration;
                if (currentIndex + 1 < spriteList.Count) {
                    currentIndex++;
                }
                GetComponent<SpriteRenderer>().sprite = spriteList[currentIndex];
            }
        } else {
            if (timer >= frameReverseDuration) {
                timer -= frameReverseDuration;
                if (currentIndex - 1 >= 0) {
                    currentIndex--;
                }
                GetComponent<SpriteRenderer>().sprite = spriteList[currentIndex];
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("asdasd");
        isLightened = true;
        timer = 0;
    }

    void OnTriggerExit2D(Collider2D other) {
        isLightened = false;
        timer = 0;
    }
}
