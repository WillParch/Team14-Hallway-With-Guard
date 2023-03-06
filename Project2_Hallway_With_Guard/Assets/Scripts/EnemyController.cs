using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    public GameObject roof;
    public GameObject eye1;
    public GameObject eye2;
    public GameObject fire;
    public GameObject roomLight;
    public GameObject roomLight2;
    public float interval = 1f;
    

    private void Start()
    {
        eye1.gameObject.SetActive(false);
        eye2.gameObject.SetActive(false);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            
        }

        if(collision.gameObject.tag == "Barrier")
        {
            Destroy(roof);
            eye1.gameObject.SetActive(true);
            eye2.gameObject.SetActive(true);
            
        }

        if(collision.gameObject.tag == "Barrier2")
        {
            StartCoroutine(Flame());
            eye1.gameObject.SetActive(true);
            eye2.gameObject.SetActive(true);
        }

        if(collision.gameObject.tag == "Barrier3")
        {
            Destroy(roomLight);
            Destroy(roomLight2);
            eye1.gameObject.SetActive(true);
            eye2.gameObject.SetActive(true);
        }
    }

    IEnumerator Flame()
    {
            while(true)
            {
                fire.gameObject.SetActive(false);
                yield return new WaitForSeconds(interval);
                fire.gameObject.SetActive(true);
                yield return new WaitForSeconds(interval);
            }
    }
}
