using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private float torque = 200f;
    [SerializeField] private KeyCode impulseKey = KeyCode.A;
    [SerializeField] private bool isNegative = false;

    private float Torque => torque * (isNegative ? -1 : 1);

    private void FixedUpdate()
    {
        rb.AddTorque(Torque * (Input.GetKey(impulseKey) ? 1 : -1));
    }
}
