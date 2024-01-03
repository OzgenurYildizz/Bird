using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update

// public int playScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSound;
    public AudioSource gameOverSound;

    private int score;

    [ContextMenu("Increase Score")]

    public void Start()
    {
        highScoreText.text= PlayerPrefs.GetInt("HighScore" ,0).ToString();
       
    }
    public void addScore(int scoreToAdd)
    {
        score =score + scoreToAdd;
        scoreText.text = score.ToString();
        scoreSound.Play();
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverSound.Play();

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            
            PlayerPrefs.SetInt("HighScore" , score);
            highScoreText.text = score.ToString();
        }

    }
}
