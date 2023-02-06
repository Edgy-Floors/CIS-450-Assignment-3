/*
 * EJ Flores
 * Cannonball.cs
 * Assignment 3
 * This script just makes a cannonball go upwards on screen.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public int damage = 3;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime);
    }
}
