using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ChestOpenTrigger : MonoBehaviour
{
    public Transform chestTransform;
    private Vector3 chestMovement;

    public void openChest()
    {
        StartCoroutine(opener());
    }

    public void closeChest()
    {
        chestMovement.x = 40;
        chestTransform.Rotate(chestMovement);
    }

    public IEnumerator opener()
    {
        chestMovement.x = -40;
        chestTransform.Rotate(Vector3.left * Time.deltaTime, 40);
        yield return null;
    }
}
