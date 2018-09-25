using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripperScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player") {
			Debug.Log("tripping");

			GameObject trip = this.gameObject;
			GameObject player = GameObject.Find("Player");
				
			trip.GetComponent<Animate>().tripping = true;
			//Destroy(gameObject);
			player.transform.position = new Vector2(136.4f, -10.5f);
			player.gameObject.SetActive(false);

			player.GetComponent<Player>().canWalk = false;
			player.GetComponent<Player>().isWalking = false;
			player.GetComponent<Player>().moveSpeed = 0;
		}
	}
}
