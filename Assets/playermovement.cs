﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour {

	public float moveSpeed = 0.1f;
	SpriteRenderer spr;

	public KeyCode rightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.LeftArrow;
	public float bottomOfScreen = -5;
	public string sceneToSwitchToOnDeath = "GameOverScene";
	public GameObject cheesePrefab;
	private bool cheeseSpawned;
	private bool cheeseDestroyed;
	private GameObject activeCheese;


	// Use this for initialization
	void Start () {

		spr = GetComponent<SpriteRenderer> ();
		float randomNum = Random.Range (0, 5.5f);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(rightKey)) {
			transform.Translate (moveSpeed, 0, 0);
			spr.flipX = false;
		}
		if (Input.GetKey(leftKey)) {
			transform.Translate (-moveSpeed, 0, 0);
			spr.flipX = true;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate (0, moveSpeed, 0);
			spr.flipY = true;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -moveSpeed, 0);
			spr.flipY = false;
		}
		if (transform.position.x >= -1 && transform.position.x <= 1 && transform.position.y >= -1 && transform.position.y <= 1) {
			SceneManager.LoadScene ("gameoverscene");
		}

		}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "circle") {
			if (!cheeseSpawned) {
				activeCheese = Instantiate (cheesePrefab);
				activeCheese.transform.position = new Vector3 (5, -4, 0);
				cheeseSpawned = true;
			}
		}

	

			if (other.gameObject.tag == "destroycircle") {
				if (cheeseSpawned) {
					Destroy (activeCheese);
					cheeseSpawned = false;
				}
			}
		}
}

