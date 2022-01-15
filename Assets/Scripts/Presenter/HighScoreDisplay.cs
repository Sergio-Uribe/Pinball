using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    [SerializeField] private HighScoreSaver highScore = null;
    [SerializeField] private Text text = null;
    [SerializeField] private StringReplacer replacer = new StringReplacer("High Score: {hs}");

    private void Awake()
    {
        highScore.OnHighScoreUpdated += HandleHighScoreUpdated;
    }

    private void Start()
    {
        text.text = replacer.GetReplacedText(highScore.Amount);
    }

    private void HandleHighScoreUpdated()
    {
        text.text = replacer.GetReplacedText(highScore.Amount);
    }
}
