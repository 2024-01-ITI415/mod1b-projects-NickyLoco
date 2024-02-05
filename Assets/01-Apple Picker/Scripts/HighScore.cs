using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    void Awake()
{
    // If the player high score already exists then read it
    if (PlayerPrefs.HasKey("HighScore"))
    {
        // Read the existing high score from PlayerPrefs
        int savedHighScore = PlayerPrefs.GetInt("HighScore");

        // Set the static score variable to the saved high score
        score = savedHighScore;
    }
    else
    {
        // If there is no saved high score, set the PlayerPrefs to the default score
        PlayerPrefs.SetInt("HighScore", score);
    }
}
    void Update() {
    Text gt	= this.GetComponent<Text>();
    gt.text	= "High Score: "+score;
    // Update	the	PlayerPrefs	HighScore	if	necessary
    if (score > PlayerPrefs.GetInt("HighScore")) {
    PlayerPrefs.SetInt("HighScore",	score);
  }
  }
}