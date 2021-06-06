using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollerController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.AddForce(movement * 1);
    }
}
