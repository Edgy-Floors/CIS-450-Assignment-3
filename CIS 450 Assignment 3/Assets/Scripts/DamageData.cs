using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageData : MonoBehaviour, ISubject
{
    private List<IObserver> obs = new List<IObserver>();
    public int dmg = 3;

    public void startObserve(IObserver o)
    {
        obs.Add(o);
        o.updateDamage();
    }

    public void stopObserve(IObserver o)
    {
        if(obs.Contains(o))
        {
            obs.Remove(o);
        }
    }

    public void onObserve()
    {
        foreach(IObserver x in obs)
        {
            x.updateDamage();
        }
        Debug.Log("You have notified an observer from DamageData");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            dmg++;
            onObserve();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            dmg--;
            onObserve();
        }
    }
}
