using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText, highScoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        CheckHighScore(); //Calls to check if current score is higher than high score;
    }
    public void CheckHighScore() //Manages the high score;
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore); //PlayerPrefs can be used to permantently store values;
            highScoreText.text = playerScore.ToString();
        }
    }
    public void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighScore", 0); //Resets the high score;
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
