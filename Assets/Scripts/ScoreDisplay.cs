using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + scoreKeeper.score;
	}
}
