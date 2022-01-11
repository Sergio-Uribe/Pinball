using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    [SerializeField] private StringReplacer scoreStrReplacer = new StringReplacer("{s} pts");
    [SerializeField] private ScoreUpdater score = null;

    private void Awake()
    {
        score.OnScoreAdded += HandleScoreAdded;
    }

    private void HandleScoreAdded(int scoreCount)
    {
        scoreText.text = scoreStrReplacer.GetReplacedText(scoreCount);
    }
}
