using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int currentHealth;

    public UI gameUI;
    void Start()
    {
        currentHealth = health;

        gameUI.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        gameUI.SetHealth(currentHealth);
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
        } else if(gameObject.name == "Player")
        {
            Time.timeScale = 0;
            gameUI.losePanel.SetActive(true);
        }
    }
}
