using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Light sun;
    public float dayTime =1;
    public float nightTime = 1;
    public float lightTimer;
    public bool day;
    public bool night;
    public float daylightIntensity;
    public  int dayNum = 0;
   
    public static DayNight i;

    void Awake()
    {
        if(i == null)
        {
            i = this;
            DontDestroyOnLoad(gameObject);
        } else if(i != null)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        sun.intensity = daylightIntensity;
        day = true;
        night = false;
    }
    void Update()
    {
        lightTimer += Time.deltaTime;

        if (day)
        {
            if (lightTimer >= dayTime)
            {
                sun.intensity -= Time.deltaTime;
            }
            if(sun.intensity == 0)
            {
                lightTimer = 0;
                day = false;
                night = true;
            }
        }

        if (night)
        {
            if (lightTimer >= nightTime)
            {
                sun.intensity += Time.deltaTime;
            }
            if (sun.intensity >= daylightIntensity)
            {
                lightTimer = 0;
                day = true;
                night = false;
                dayNum++;
            }

        }


    }
}
