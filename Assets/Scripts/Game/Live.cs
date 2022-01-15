using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    [SerializeField] private int initialLives = 3;

    public event Action OnLivesRemoved = null;

    public int LivesCount { get; private set; }

    private void Awake()
    {
        LivesCount = initialLives;
    }

    public void RemoveLive()
    {
        LivesCount = Mathf.Max(LivesCount - 1, 0);
        OnLivesRemoved?.Invoke();
    }

}
