using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    public GameObject roof;
    public GameObject roof2;
    public GameObject fire;
    public GameObject roomLight;
    public float interval = 1f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }

        if(collision.gameObject.tag == "Barrier")
        {
            Destroy(roof);
            Destroy(roof2);
        }

        if(collision.gameObject.tag == "Barrier2")
        {
            StartCoroutine(Flame());
        }

        if(collision.gameObject.tag == "Barrier3")
        {
            Destroy(roomLight);
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
