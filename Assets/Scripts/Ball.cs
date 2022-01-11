using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector2 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }

    public void Respawn()
    {
        transform.position = initialPos;
    }
}
