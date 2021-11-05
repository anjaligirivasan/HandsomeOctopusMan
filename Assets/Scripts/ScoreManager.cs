using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    // -----population variables-----
    public int score;
    public Text scoreText;

    // -------time-------
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;

    public GameObject gameOverUI;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        timerIsRunning = true;
    }

    private void Update()
    { 
        if (score <= 0)
            GameOver();

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out");
                GameOver();
                timerIsRunning = false;
            }
        }
    }

    // population methods ------------------------------

    public void DecreaseCount(int amount)
    {
        
       score -= amount;
       UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = "Population: " + score;
        //TotalScore.Instance.ScoreDisplay(score);
    }

    public void GetScore(Text pop)
    {
        if(score <= 0)
        {
            pop.text = "Population: " + score + "\n\nVictory!";
        }
        else
        {
            pop.text = "Population: " + score;
        }
    }

    // time methods ---------------------------------------

    void DisplayTime(float displayTime)
    {
        displayTime += 1;
        float minutes = Mathf.FloorToInt(displayTime / 60);
        float seconds = Mathf.FloorToInt(displayTime % 60);

        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void GetTime(Text time)
    {
        time.text = timeText.text;
    }

    // screen control methods --------------------------------------------

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
    }
}
