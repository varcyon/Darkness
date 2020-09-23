using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class DarkSwarm : MonoBehaviour
{
    public int health = 5;
    public int currentHealth;
    public bool firstHit;
    public NavMeshAgent agent;
    public GameObject player;
    public bool takingDamage;
    public int takingDamageSpeed;
    public int normalSpeed;
    public List<GameObject> attackables = new List<GameObject>();

    public float attackRate = 2;
    public float attackTimer;
    public int attackDamage = 1;

    public float daylightDamageRate = 1;
    public float daylightDamageTimer;
    public int daylightDamage = 1   ;

    public AudioSource audioSource;
    public AudioClip deathSFX;

    public ObjectUI objectUI;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        objectUI.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Death();
        }


    }

    void Death()
    {
      audioSource.PlayOneShot(deathSFX, 1f);
        Destroy(gameObject);
    }


    void DaylightAttack()
    {

        daylightDamageTimer += Time.deltaTime;
            if(daylightDamageTimer > daylightDamageRate)
            {
            Debug.Log("hurt by sun");
            daylightDamageTimer = 0;
                TakeDamage(daylightDamage);
            }
        
    }

    void Attack()
    {
        if (Vector3.Distance(attackables[0].transform.position, this.transform.position) <= 2f)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer > attackRate)
            {
                attackTimer = 0;
                if(attackables[0].GetComponent<Health>() != null)
                {
                attackables[0].GetComponent<Health>().TakeDamage(attackDamage);

                }
                if (attackables[0].GetComponent<ObjectHealth>() != null)
                {
                    attackables[0].GetComponent<ObjectHealth>().TakeDamage(attackDamage);
                }
            }
        }
    }

    void Start()
    {
        currentHealth = health;
        objectUI.SetMaxHealth(health);
       agent = GetComponent<NavMeshAgent>();
        attackables.Add(GameObject.FindGameObjectWithTag("Player"));
        foreach (GameObject attackable in GameObject.FindGameObjectsWithTag("Attackable"))
        {
            attackables.Add(attackable);
        }
    }

    void SlowOnDamage()
    {
        agent.speed = takingDamageSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        attackables.RemoveAll(GameObject => GameObject == null);

        Attack();
        if (takingDamage)
        {
            SlowOnDamage();
        } else
        {
            agent.speed = normalSpeed;
        }

        if (DayNight.i.day)
        {
            DaylightAttack();
        }
        foreach (GameObject attackable in GameObject.FindGameObjectsWithTag("Attackable"))
        {
            if (!attackables.Contains(attackable))
            {
                attackables.Add(attackable);
            }
        }

            attackables = attackables.OrderBy( player => Vector3.Distance(this.transform.position, player.transform.position)).ToList();

        agent.SetDestination(attackables[0].transform.position);

    }



}
