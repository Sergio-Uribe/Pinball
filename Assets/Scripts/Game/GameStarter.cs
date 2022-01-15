using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Ball ball = null;
    [SerializeField] private GameObject panel = null;
    [SerializeField] private UnityEvent onStart = null;
    private static bool started;

    private void Start()
    {
        if (started) return;
        panel.SetActive(true);
    }

    public void StartGame()
    {
        started = true;
        onStart?.Invoke();
        ball.Respawn();
        panel.SetActive(false);
    }
}
