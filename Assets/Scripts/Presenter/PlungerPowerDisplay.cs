using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerPowerDisplay : MonoBehaviour
{
    [SerializeField] private BallPlunger plunger = null;
    [SerializeField] private Image fillArea = null;


    private void Awake()
    {
        plunger.OnPowerUpdated += HandlePowerUpdated;
    }

    private void HandlePowerUpdated(float powerPercentage)
    {
        fillArea.fillAmount = powerPercentage;
    }
}
