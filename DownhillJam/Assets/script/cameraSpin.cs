using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSpin : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
