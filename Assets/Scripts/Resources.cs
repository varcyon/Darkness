using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public static int metal;
    public static int wood;
    public static int batteries;
    public static int wiring;


    public  int Metal;
    public  int Wood;
    public  int Batteries;
    public  int Wiring;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Metal = metal;
    Wood = wood;
    Batteries = batteries;
    Wiring = wiring;
}
}
