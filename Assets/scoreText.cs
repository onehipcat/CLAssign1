using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour {

	Text myText;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Score: " + GameManager.score + "\nHigh Score: " + GameManager.highScore;
	}
}
