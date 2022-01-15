using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlunger : MonoBehaviour
{
    [SerializeField] private KeyCode impulseKey = KeyCode.Space;
    [SerializeField] private float maxPower = 20f;

    private Ball ball;

    private void Update()
    {
        if (!Input.GetKeyDown(impulseKey) || ball == null) return;
        ball.Impulse(maxPower);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.TryGetComponent<Ball>(out var ball)) return;
        this.ball = ball;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>() == null) return;
        ball = null;
    }
}
