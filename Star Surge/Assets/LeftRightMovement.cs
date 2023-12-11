using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LeftRightMovement : MonoBehaviour
{
    [SerializeField] private float movementRate = 1f;
    [SerializeField] private float[] boundaries;

    private bool goingRight;

    // Start is called before the first frame update
    void Start()
    {
        goingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(goingRight)
        {
            gameObject.transform.position += new Vector3(movementRate * Time.deltaTime,0,0);
            if(gameObject.transform.position.x > boundaries[1])
            {
                goingRight = false;
            }
        }
        else
        {
            gameObject.transform.position -= new Vector3(movementRate * Time.deltaTime,0,0);
            if(gameObject.transform.position.x < boundaries[0])
            {
                goingRight = true;
            }
        }

    }
}
