using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public UnityEngine.UI.Text tmp;
    public int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        tmp.text = "You dealt " + collision.gameObject.GetComponent<Cannonball>().damage + " damage.";
    }
}
