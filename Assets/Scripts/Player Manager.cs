using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Vector3 currentMousePosition;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
