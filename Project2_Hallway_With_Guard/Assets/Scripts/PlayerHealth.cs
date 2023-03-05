using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public CharacterController controller;
    public float speed = 12f;
    private float _gravity = -9.81f;
    [SerializeField] private float gravityMultiplier = 3.0f;
    private float _velocity;
    
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

    private void ApplyGravity()
    {
        _velocity += _gravity * gravityMultiplier * Time.deltaTime;
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
       
        
        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("LoseGame");
        }
    }
   
    
    
    // Start is called before the first frame update
   
}
