using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    [SerializeField] private int initialLives = 3;

    public event Action<int> OnLivesRemoved = null;

    public int LivesCount { get; private set; }

    private void Start()
    {
        LivesCount = initialLives;
        OnLivesRemoved?.Invoke(LivesCount);
    }

    public void RemoveLive()
    {
        LivesCount = Mathf.Max(LivesCount - 1, 0);
        OnLivesRemoved?.Invoke(LivesCount);
    }

}
