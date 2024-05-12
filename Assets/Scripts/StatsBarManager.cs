using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsBarManager : MonoBehaviour
{
    // Main bar variables
    [Header("Main bar variables")]

    public int currentValue;
    public int maxValue;

    private Image fillImage;

    private TMP_Text text;

    private void Start()
    {
        // Initialize variables

        currentValue = maxValue;

        fillImage = transform.Find("Fill").transform.gameObject.GetComponent<Image>();
        text = transform.Find("Text").GetComponent<TMP_Text>();
    }

    public void UpdateHealthValue()
    {
        // Updates the fill amount on the bar and updates the text
        fillImage.fillAmount = currentValue / maxValue;

        text.text = currentValue.ToString() + "/" + maxValue.ToString();

        // Caps the values
        if(currentValue >= maxValue)
        {
            currentValue = maxValue;
        }
        else if(currentValue <= 0)
        {
            currentValue = 0;
        }
    }

    private void Update()
    {
        // Initialize functions

        UpdateHealthValue();
    }
}
