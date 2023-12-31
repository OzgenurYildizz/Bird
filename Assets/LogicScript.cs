using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int playScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSound;
    public AudioSource gameOverSound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playScore=playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
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
    }
}
