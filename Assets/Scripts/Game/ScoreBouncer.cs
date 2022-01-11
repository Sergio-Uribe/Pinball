using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBouncer : MonoBehaviour
{
    [SerializeField] private int scoreToAdd = 25;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.TryGetComponent<ScoreUpdater>(out var score)) return;
        score.AddScore(scoreToAdd);
    }
}
