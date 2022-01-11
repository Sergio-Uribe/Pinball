using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Live live = null;
    private Vector2 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }

    public void Die()
    {
        live.RemoveLive();
        if (live.LivesCount == 0) return;
        transform.position = initialPos;
    }
}
