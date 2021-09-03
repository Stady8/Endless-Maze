using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager2 : MonoBehaviour
{
  
    public Text Highscore;

    public static int highscoreValue = 0;

    private void Start()
    {
        highscoreValue = PlayerPrefs.GetInt("highscore", highscoreValue);
        Highscore.text = highscoreValue.ToString();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() {

        Debug.Log("Quit only works for moblie");
        Application.Quit();
     }

}
