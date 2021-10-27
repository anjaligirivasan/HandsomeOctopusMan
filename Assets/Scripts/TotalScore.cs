using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public static TotalScore Instance { get; private set; }
    public float score;
    public Text scoreText;
    public Text timeText;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        
    }

    public void ScoreDisplay(float score)
    {
        scoreText.text = "Population: " + score;
    }

    public void SetScore(Text score)
    {
        scoreText.text = score.text;
    }

    public void getTime(Text timer)
    {
        timeText.text = "Time left: " + timer.text;
    }
}
