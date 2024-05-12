using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawningManager : MonoBehaviour
{

    //public PlayerManager playerManager;
    public GameObject currentTroup;

    public Vector3 currentMousePosition;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentMousePosition.z = 0f;

            Instantiate(currentTroup, currentMousePosition, transform.rotation);
        }
    }
}
