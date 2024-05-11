using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBarManager : MonoBehaviour
{
    // Main bar variables
    [Header("Main bar variables")]

    public float currentValue;
    public float maxValue;

    private Image fillImage;

    private void Start()
    {
        // Initialize variables

        currentValue = maxValue;
    }

    public void UpdateValue()
    {
        // Updates the value of the bar and updates the bar visuals
        float targetFillAmount = currentValue / maxValue /* gets the normalized value because the value is between 0 and 1*/;
        fillImage.fillAmount = targetFillAmount;
    }
}
