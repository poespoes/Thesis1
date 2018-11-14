using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerShake : MonoBehaviour
{
	public float shakeRange;
	public Vector2 durationRange;

	float shakeOffset = 0;
	float shakeTimer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.T))
		{
			BeamShake();
		}
	}
	
	void BeamShake() {
		shakeTimer -= Time.deltaTime;
		if (shakeTimer < 0) {
			shakeTimer += Random.Range(durationRange.x, durationRange.y);
			if (shakeOffset > 0)
				shakeOffset = -shakeRange;
			else
				shakeOffset = shakeRange;
		}

		Vector3 euler = transform.eulerAngles;
		euler.z += shakeOffset;
		transform.eulerAngles = euler;
	}
}
