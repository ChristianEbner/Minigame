using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int duckieValue;

    private int score;


	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
		
	}

    void OnTriggerEnter2D()
    {
        score += duckieValue;
        UpdateScore();
    }

    void UpdateScore ()
    {
        scoreText.text = "score\n" + score;
    }
}
