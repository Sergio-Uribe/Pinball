using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreSaver : MonoBehaviour
{
    [SerializeField] private ScoreUpdater score = null;

    public event Action OnHighScoreUpdated = null;

    private const string highScoreKey = "HIGH_SCORE";

    public int Amount
    {
        get
        {
            if (!PlayerPrefs.HasKey(highScoreKey)) return 0;
            return PlayerPrefs.GetInt(highScoreKey);
        }
    }


    private void Awake()
    {
        score.OnScoreAdded += HandleScoreAdded;
    }

    private void HandleScoreAdded(int score)
    {
        if (score <= Amount) return;
        PlayerPrefs.SetInt(highScoreKey, score);
        OnHighScoreUpdated?.Invoke();
    }
}
