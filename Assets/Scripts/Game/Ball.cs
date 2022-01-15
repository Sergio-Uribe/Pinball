using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Live live = null;
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private Transform spawnPoint = null;

    public void Die()
    {
        live.RemoveLive();
        if (live.LivesCount == 0) return;
        Respawn();
    }

    public void Respawn()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        transform.position = spawnPoint.position;
    }

    public void Impulse(float force)
    {
        rb.velocity = Vector2.up * force;
    }
}
