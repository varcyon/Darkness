using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject swarm;
    public float spawnRate = 1f;
    public float spawnTimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DayNight.i.night)
        {
            spawnTimer += Time.deltaTime;
            if(spawnTimer > spawnRate)
            {
                spawnTimer = 0;
                Instantiate(swarm, transform.position, Quaternion.identity);
            }
        } else
        {
            spawnTimer = 0;
        }
    }
}
