using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowCrasher : MonoBehaviour
{
    public GameObject window;
    public GameObject glassPieces;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("HeavyThrowable"))
        {
            windowShatter();
        }
    }

    private void windowShatter()
    {
        Destroy(window);
        Instantiate(glassPieces);
    }
}
