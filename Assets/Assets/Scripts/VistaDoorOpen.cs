using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SunTemple;

public class VistaDoorOpen : MonoBehaviour
{
    public Door DoorToOpen;
    public GameObject key;

    private bool doorStatus;    //closed = true, open = false
    private bool locked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(key) && locked)
        {
            locked = false;
        }
    }
}
