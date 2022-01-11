using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryPresenter : MonoBehaviour
{
    [SerializeField] private Live live = null;
    [SerializeField] private GameObject panel = null;

    private void Awake()
    {
        live.OnLivesRemoved += CheckLivesCount;
    }

    private void Start()
    {
        panel.SetActive(false);
    }

    private void CheckLivesCount(int livesCount)
    {
        if (livesCount > 0) return;
        panel.SetActive(true);
    }
}
