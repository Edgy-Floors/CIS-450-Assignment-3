/*
 * EJ Flores
 * ISubject.cs
 * Assignment 3
 * 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    public void startObserve(IObserver o);
    public void stopObserve(IObserver o);
    public void onObserve();
}
