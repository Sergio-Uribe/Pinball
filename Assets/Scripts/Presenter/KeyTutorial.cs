using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyTutorial : MonoBehaviour
{
    [SerializeField] private KeyCode key = KeyCode.Space;

    [SerializeField] private UnityEvent onPress = null;

    private void Update()
    {
        if (!Input.GetKeyDown(key)) return;
        onPress?.Invoke();
    }

}
