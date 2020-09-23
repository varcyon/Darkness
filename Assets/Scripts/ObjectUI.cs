using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUI : MonoBehaviour
{
    public Slider objectSlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMaxHealth(int health)
    {
        objectSlider.maxValue = health;
        objectSlider.value = health;
    }
    public void SetHealth(int health)
    {
        objectSlider.value = health;
    }

    public void SetMaxEnergy(float energy)
    {
        objectSlider.maxValue = energy;
        objectSlider.value = energy;
    }
    public void SetEnergy(float energy)
    {
        objectSlider.value = energy;
    }

}
