using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDamage : MonoBehaviour
{
    public int lightDamage = 1;
    public int initialDamage = 2;
    public float damagePulseTime = 1;
    public float damageTimer;


    private void Update()
    {
        damageTimer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("Swarm") && !other.GetComponent<DarkSwarm>().firstHit)
        {
            other.GetComponent<DarkSwarm>().TakeDamage(initialDamage);
            other.GetComponent<DarkSwarm>().firstHit = true;
            other.GetComponent<DarkSwarm>().takingDamage = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (damageTimer > damagePulseTime && other.CompareTag("Swarm"))
        {
            other.GetComponent<DarkSwarm>().TakeDamage(lightDamage);
            other.GetComponent<DarkSwarm>().takingDamage = true;
            damageTimer = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Swarm"))
        {
        other.GetComponent<DarkSwarm>().takingDamage = false;

        }

    }

}
