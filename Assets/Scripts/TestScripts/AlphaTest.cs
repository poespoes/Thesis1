using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaTest : MonoBehaviour {

    public Color A = Color.magenta;
    public Color B = Color.blue;
    public float speed = 1.0f;
    public float lerpProgress = 0;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.Alpha1)) {
            lerpProgress += 0.01f;
            Debug.Log("Bumping up!");
        }


        spriteRenderer.color = Color.Lerp(A, B, lerpProgress);
    }
}