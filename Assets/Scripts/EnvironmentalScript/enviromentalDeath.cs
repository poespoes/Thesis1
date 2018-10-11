using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enviromentalDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "Player")
		{
			Die();
		}
	}
	
	
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


	public void Die()
	{
		GameObject blackout = GameObject.Find("BlackoutPanel");
		blackout.GetComponent<Image>().CrossFadeAlpha(255,5.0f,false);
		Invoke("Restart",2);
		
	
	}

}
