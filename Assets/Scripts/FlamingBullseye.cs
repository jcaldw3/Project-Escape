using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamingBullseye : MonoBehaviour
{
    public string objName;
    public string capsuleColliderName;
    public GameObject keyInBalloonPrefab;
    public GameObject balloonPrefab;
    public Transform balloonSpawnPoint;

    private bool bullseyeAndFire;

    // Start is called before the first frame update
    void Start()
    {
        bullseyeAndFire = false;
    }

    public bool conditionMet()
    {
        return bullseyeAndFire;
    }

    private void keyTrigger()
    {
        bullseyeAndFire = true;
        Debug.Log("Entered function");

        GameObject balloon1 = Instantiate(balloonPrefab, balloonSpawnPoint.transform);
        GameObject balloon2 = Instantiate(keyInBalloonPrefab, balloonSpawnPoint.transform);
        GameObject balloon3 = Instantiate(balloonPrefab, balloonSpawnPoint.transform);
        Debug.Log("Balloons released");
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!conditionMet() && collision.gameObject.name != capsuleColliderName && collision.gameObject.name == objName)  // && collision.gameObject.name == objName)
        {
            Debug.Log("Contact made with " + collision.gameObject.name);
            keyTrigger();
        }
    }
}
