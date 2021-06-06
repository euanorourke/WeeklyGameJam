using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class loseScript : MonoBehaviour
{
    public GameObject player;
    public GameObject particle;
    private Renderer rend;
    void Start()
    {
        particle.SetActive(false);
    }


    void LateUpdate()
    {
        if (transform.position.y < -10)
        {
            Rigidbody rb = player.gameObject.GetComponent<Rigidbody>();
            Rigidbody rbParticle = particle.gameObject.GetComponent<Rigidbody>();
            rend = GetComponent<Renderer>();
            rend.enabled = false; //Make player invisible

            rb.velocity = Vector3.zero;
            rbParticle.velocity = Vector3.zero; //Stop movement of the player and particleSystem
            particle.SetActive(true); //Enable Particles
            
            StartCoroutine(SceneLoad(1f)); //Reloads scene 1 second after calling and allows particle system to fire
        }

        
    }

    IEnumerator SceneLoad(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Reload Scene
        Debug.Log("CUM");
    }
}
