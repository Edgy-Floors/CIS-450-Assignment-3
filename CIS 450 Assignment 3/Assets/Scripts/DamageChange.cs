/*
 * EJ Flores
 * DamageChange.cs
 * Assignment 3
 * This script is the observer for an event, updating the cannonball's damage.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageChange : MonoBehaviour, IObserver
{
    public DamageData dmg;
    public Cannonball c;

    public void updateDamage()
    {
        c.damage = dmg.dmg;
    }

    private void Start()
    {
        dmg.startObserve(this);
    }
}
