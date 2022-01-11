using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public event Action<int> OnScoreAdded = null;

    private int scoreCount;

    private void Start()
    {
        OnScoreAdded?.Invoke(scoreCount);
    }

    public void AddScore(int count)
    {
        scoreCount += count;
        OnScoreAdded?.Invoke(scoreCount);
    }
}
