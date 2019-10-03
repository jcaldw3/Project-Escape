using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPuzzle : MonoBehaviour
{
    public Transform lever1;
    public Transform lever2;
    public Transform lever3;
    public Transform lever4;
    public GameObject wall;
    public AudioSource boulderMoveFX;

    private int upRotationAngle;
    private int downRotationAngle;
    private bool opened;

    // Start is called before the first frame update
    void Start()
    {
        upRotationAngle = 40;
        downRotationAngle = 320;
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (conditionsMet() && !opened)
        {
            opened = true;
            StartCoroutine(audioWait());
        }
    }

    IEnumerator audioWait()
    {
        boulderMoveFX.Play();
        /*while (boulderMoveFX.isPlaying)
        {
            yield return null;
        }*/
        yield return new WaitForSeconds(4.0f);
        Debug.Log("audio finished");
        Destroy(wall);
        
        GetComponent("LeverPuzzle").gameObject.SetActive(false);
        yield return null;

        //WaitWhile.Equals(boulderMoveFX.isPlaying, false);
    }

    bool conditionsMet()
    {
        int adjustedX1 = (int) lever1.rotation.eulerAngles.x;
        int adjustedX2 = (int) lever2.rotation.eulerAngles.x;
        int adjustedX3 = (int) lever3.rotation.eulerAngles.x;
        int adjustedX4 = (int) lever4.rotation.eulerAngles.x;

        if (adjustedX1 == downRotationAngle && adjustedX2 == downRotationAngle && adjustedX3 == upRotationAngle && adjustedX4 == downRotationAngle)
        {
            return true;
        }

        return false;
    }
}
