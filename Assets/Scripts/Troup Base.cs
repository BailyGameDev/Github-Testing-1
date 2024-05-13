using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroupBase : MonoBehaviour
{

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Make this only run for 0.5 seconds.
        //This isn't a permanent Solution.

        if (collision.gameObject.tag == "King")
        {
            Destroy(gameObject);
        }
    }
}