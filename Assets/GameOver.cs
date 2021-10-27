using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text popText;
    public Text timeText;

    private void OnEnable()
    {
        ScoreManager.Instance.GetScore(popText);
        ScoreManager.Instance.GetTime(timeText);
    }
}
