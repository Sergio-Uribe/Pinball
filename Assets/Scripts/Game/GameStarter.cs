using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Ball ball = null;
    [SerializeField] private GameObject panel = null;
    private static bool started;

    private void Start()
    {
        if (started) return;
        panel.SetActive(true);
    }

    public void StartGame()
    {
        started = true;
        ball.Respawn();
        panel.SetActive(false);
    }
}
