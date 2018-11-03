using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLight : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    public Vector3 TargetScale = new Vector3(1f, 1f, 1f);
    public Vector3 StartingScale = new Vector3(5f, 5f, 5f);
    public float TimeToScale = 5.0f;

    private bool isScaling = true;
    private float dimTime = 0.0f;

    private void Start() {
        transform.localScale = StartingScale;
    }

    private void Update() {
        if (isScaling) {
            dimTime += Time.deltaTime / TimeToScale;
            if (dimTime >= 1.0f) {
                transform.localScale = TargetScale;
                isScaling = false;
            } else {
                transform.localScale = Vector3.Lerp(StartingScale, TargetScale, dimTime);
            }
        }
    }
}

