using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

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

        for(int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).name == "Fill")
            {
                fillImage = transform.GetChild(i).GetComponent<Image>();
            }
            else if(transform.GetChild(i).name == "Text")
            {
                text = transform.GetChild(i).GetComponent<TMP_Text>();
            }
        }
    }

    public void UpdateHealthValue()
    {
        // Caps the values
        if (currentValue > maxValue)
        {
            currentValue = maxValue;
        }
        else if (currentValue < 0)
        {
            currentValue = 0;
        }

        // Updates the fill amount on the bar and updates the text
        fillImage.fillAmount = (float)currentValue / (float)maxValue;

        text.text = currentValue.ToString() + "/" + maxValue.ToString();
    }

    private void Update()
    {
        // Initialize functions

        UpdateHealthValue();
    }
}
