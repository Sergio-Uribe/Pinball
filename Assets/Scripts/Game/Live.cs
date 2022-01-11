using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    [SerializeField] private int initialLives = 3;

    public event Action<int> OnLivesRemoved = null;

    private int livesCount;

    private void Start()
    {
        livesCount = initialLives;
        OnLivesRemoved?.Invoke(livesCount);
    }

    public void RemoveLive()
    {
        livesCount--;
        OnLivesRemoved?.Invoke(livesCount);
    }

}
