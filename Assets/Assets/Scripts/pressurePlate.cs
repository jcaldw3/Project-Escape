using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pressurePlate : MonoBehaviour
{
    public Transform pressurePlateTransform;
    public string objName;
    public GameObject particleEffectPrefab;
    public bool newTeleportPoint;
    public GameObject teleportPrefab;
    public Transform hiddenTeleportPoint;
    public bool newObject;
    public GameObject newObjectPrefab;
    public Transform newObjectPoint;
    public bool alterEnvironment;
    public Transform environmentChange;

    private bool particleActivated;
    private bool pressureActivated;

    private void Start()
    {
        particleActivated = false;
        pressureActivated = false;
    }

    public bool isActive()
    {
        return pressureActivated;
    }

    private void pressureActivate()
    {
        pressureActivated = true;
        pressurePlateReaction();
    }

    private void pressureDeactivate()
    {
        pressureActivated = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive() && collision.gameObject.name == objName)
        {
            pressureActivate();
        }
    }

     private void OnCollisionExit(Collision collision)
    {
        if(isActive() && collision.gameObject.name == objName)
        {
            pressureDeactivate();
        }
    }

    private void pressurePlateReaction()
    {
        if (!particleActivated)
        {
            GameObject Particles = Instantiate(particleEffectPrefab, pressurePlateTransform);
            if (newTeleportPoint)
            {
                Instantiate(teleportPrefab, hiddenTeleportPoint);
            }
            if (newObject)
            {
                Instantiate(newObjectPrefab, newObjectPoint);
            }
            if (alterEnvironment)
            {
                Vector3 newPos = new Vector3(environmentChange.position.x, environmentChange.position.y, -5.0f);
                environmentChange.SetPositionAndRotation(newPos, environmentChange.rotation);
            }
            particleActivated = true;
            Destroy(Particles, 10f);
        }
    }  
}
