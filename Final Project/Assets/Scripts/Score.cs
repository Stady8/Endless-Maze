using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    public static int highscoreValue = 0;
    public Text score;
    public Text score2;
    public Text Highscore;
 


    public GameControl GameControlScript;

    void Awake()
    {
        score = GetComponent<Text>();
        InvokeRepeating("AddToScore", 1.0f, 1.0f);

        scoreValue = 0;
        highscoreValue = PlayerPrefs.GetInt("highscore", highscoreValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > highscoreValue)
        {
            highscoreValue = scoreValue;

            PlayerPrefs.SetInt("highscore", highscoreValue);

        }
        highscoreValue = PlayerPrefs.GetInt("highscore", highscoreValue);
        Highscore.text = highscoreValue.ToString();

    }

    void AddToScore()
    {
        if (GameControlScript.gameOver == false)
        {
            scoreValue++;
            score.text = scoreValue.ToString();
            score2.text = scoreValue.ToString();

        }
      
    }
}

