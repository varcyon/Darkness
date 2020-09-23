using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour
{
    public int health = 100;
    public int currentHealth;

    public ObjectUI objectUI;
        
    void Start()
    {
        currentHealth = health;

        objectUI.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        objectUI.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        if(gameObject.name != "Player")
        {
            Destroy(gameObject);
        }
    }
}
