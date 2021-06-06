using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOnTouch : MonoBehaviour
{
    private bool moving;
    public GameObject player;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player)
        {
            collision.transform.SetParent(transform, true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == player)
        {
            collision.transform.parent.SetParent(null, true);
        }
    }
}
