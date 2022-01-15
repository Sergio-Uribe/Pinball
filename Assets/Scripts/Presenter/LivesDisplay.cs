using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] private Text livesText = null;
    [SerializeField] private Live live = null;

    private void Awake()
    {
        live.OnLivesRemoved += UpdateLivesText;
    }

    private void Start()
    {
        UpdateLivesText();
    }

    private void UpdateLivesText()
    {
        int livesCount = live.LivesCount;
        livesText.text = livesCount.ToString();
    }
}
