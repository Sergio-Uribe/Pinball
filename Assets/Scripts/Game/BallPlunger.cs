using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlunger : MonoBehaviour
{
    [SerializeField] private KeyCode impulseKey = KeyCode.Space;
    [SerializeField] private float maxPower = 20f;
    [SerializeField] private float impulseRate = 30f;

    private Ball ball;

    private float power;

    public event Action<float> OnPowerUpdated = null;

    private void Awake()
    {
        UpdatePower(0f);
    }

    private void Update()
    {
        if (ball == null) return;
        if (Input.GetKeyDown(impulseKey))
            UpdatePower(0f);
        else if (Input.GetKey(impulseKey))
            UpdatePower(power + impulseRate * Time.deltaTime);
        else if (Input.GetKeyUp(impulseKey))
            ball.Impulse(power);
    }

    private void UpdatePower(float newPower)
    {
        power = Mathf.Min(newPower, maxPower);
        OnPowerUpdated?.Invoke(power / maxPower);
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
