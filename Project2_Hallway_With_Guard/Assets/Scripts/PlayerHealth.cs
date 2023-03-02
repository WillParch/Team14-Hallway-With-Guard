using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public CharacterController controller;
    public float speed = 12f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
        
        
    }

    void Update()
    {
       float x = Input.GetAxis ("Horizontal");
    float z = Input.GetAxis ("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        
    }

    

    public void TakeDamage(int damage)
    {
        health -= damage;
       
        
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
   

    
    // Start is called before the first frame update
   
}
