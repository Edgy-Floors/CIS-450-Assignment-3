/*
 * EJ Flores
 * CannonController.cs
 * Assignment 3
 * This script has functionality for pressing spacebar to fire a cannonball.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(cannonball);
        }
    }

}
