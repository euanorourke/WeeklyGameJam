using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class shooter : MonoBehaviour
{
    public GameObject player;
    private GameObject bullet;
    public GameObject projectile;

    public float distance;
    public float timeBetweenShot;
    public float repeatRate;

    void Start()
    {
        player = GameObject.Find("player");
        InvokeRepeating("shoot", timeBetweenShot, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((player.transform.position - this.transform.position).sqrMagnitude < distance * 3)
        {
            transform.LookAt(player.transform);
            
        }
    }

    private void shoot()
    {
        if ((player.transform.position - this.transform.position).sqrMagnitude < distance * 3)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            GameObject bullet = Instantiate(projectile, (transform.position + new Vector3(0, 1, 0)), projectile.transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse);
            Debug.Log("FIRE");
        }
        
    }
}
