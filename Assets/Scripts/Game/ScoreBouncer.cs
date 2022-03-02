using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBouncer : MonoBehaviour
{
    [SerializeField] private int scoreToAdd = 25;

    public static event Action<int> OnScoreBounce = null;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>() == null) return;
        OnScoreBounce?.Invoke(scoreToAdd);
    }
}
