using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class DialPuzzle : MonoBehaviour
{
    public DialPuzzleLocks largeDial;
    public DialPuzzleLocks mediumDial;
    public DialPuzzleLocks smallDial;
    public UnityEvent doorAnimation;

    // Update is called once per frame
    void Update()
    {
        if(largeDial.unlocked() && mediumDial.unlocked() && smallDial.unlocked())
        {
            doorAnimation.Invoke();
        }
    }
}
