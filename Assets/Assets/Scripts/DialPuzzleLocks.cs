using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialPuzzleLocks : MonoBehaviour
{
    public Collider dial;

    private bool dialUnlocked;

    // Start is called before the first frame update
    void Start()
    {
        dialUnlocked = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals(dial.gameObject.name))
        {
            dialUnlocked = true;
            Debug.Log(dial.name + " is unlocked");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals(dial.gameObject.name))
        {
            dialUnlocked = false;
            Debug.Log(dial.name + " is locked again");
        }
    }

    public bool unlocked()
    {
        return dialUnlocked;
    }
}