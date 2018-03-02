using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int score = 0;
	public static int highScore = 0;

	public static void readHIghScoreFromDisk() {
		if (PlayerPrefs.HasKey ("highScoreOnDisk")) {
			highScore = PlayerPrefs.GetInt ("highScoreOnDisk");
		} else {
			highScore = 0;
		}
	}

	public static void maybeUpdateHighScore(){
		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt ("highScoreOnDisk", highScore);
			PlayerPrefs.Save ();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
