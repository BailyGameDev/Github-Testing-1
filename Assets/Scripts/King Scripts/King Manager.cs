using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingManager : MonoBehaviour
{

    public GameManager gameManager;
    public GameManager gm;

    public bool on;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gm = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        //on = gm.isPlaying;
    }
}
