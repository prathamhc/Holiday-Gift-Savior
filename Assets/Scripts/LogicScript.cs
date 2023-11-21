using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScr;
    public GameObject Gift;
    public GameObject HandSpawn;

    [ContextMenu("Increase Score")]
    public void AddScore(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }

    public void RestartScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScr.SetActive(true);
        Gift.SetActive(false);
        HandSpawn.SetActive(false);
    }
}

