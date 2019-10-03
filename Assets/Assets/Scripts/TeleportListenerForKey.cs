using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR.Extras;

public class TeleportListenerForKey : MonoBehaviour
{
    public GameObject leftController;
    public GameObject rightController;
    public string keyName;
    public GameObject teleportScript;

    private Rigidbody leftConnectedObject;
    private Rigidbody rightConnectedObject;
    private TeleportPoint teleportToggle;
    
    
    private void Start()
    {
        teleportToggle = teleportScript.GetComponent<TeleportPoint>();
    }
    
    // Update is called once per frame
    void Update()
    {
        leftConnectedObject = leftController.GetComponentInChildren<Rigidbody>();
        rightConnectedObject = rightController.GetComponentInChildren<Rigidbody>();

        if (leftConnectedObject != null)
        {
            triggerUnlockLeftHand();
        }
        else if (rightConnectedObject != null)
        {
            triggerUnlockRightHand();
        }
        else if(teleportToggle.locked == false)
        {
            teleportToggle.locked = true;
        }
    }

    void triggerUnlockLeftHand()
    {
        if (leftConnectedObject.gameObject.name == keyName)
        {
            teleportToggle.locked = false;
        }
        else
        {
            teleportToggle.locked = true;
        }
    }

    void triggerUnlockRightHand()
    {
        if (rightConnectedObject.gameObject.name == keyName)
        {
            teleportToggle.locked = false;
        }
        else
        {
            teleportToggle.locked = true;
        }
    }
}
