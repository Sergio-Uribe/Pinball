using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public event Action<int> OnScoreAdded = null;

    private int scoreCount;

    private void Awake()
    {
        ScoreBouncer.OnScoreBounce += AddScore;
    }

    private void Start()
    {
        OnScoreAdded?.Invoke(scoreCount);
    }

    private void OnDestroy()
    {
        ScoreBouncer.OnScoreBounce -= AddScore;
    }

    private void AddScore(int count)
    {
        scoreCount += count;
        OnScoreAdded?.Invoke(scoreCount);
    }
}
