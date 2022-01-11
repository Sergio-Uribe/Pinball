using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Live live = null;
    [SerializeField] private Transform[] spawnPoints = new Transform[0];

    public void Die()
    {
        live.RemoveLive();
        if (live.LivesCount == 0) return;
        Respawn();
    }

    public void Respawn()
    {
        transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
    }
}
