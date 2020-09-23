using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour
{
    public GameObject flashlight;
    public  static float flashlightEnergy = 100;
    public bool isOn = false;
    public float energyConsumptionSpeed = 1f;
    public float rechargeSpeed = .5f;

    public UI gameUI;

    void Start()
    {
        flashlight.SetActive(false);
        gameUI.SetMaxEnregy(FlashLight.flashlightEnergy);
        
    }

    // Update is called once per frame
    void Update()
    {
        flashlightEnergy = Mathf.Clamp(flashlightEnergy, 0, 100);
        if (Input.GetKeyDown(KeyCode.E) && flashlightEnergy > 0)
        {
           
            flashlight.SetActive(!flashlight.activeSelf);
            isOn = !isOn;
        }

        if (isOn)
        {
            flashlightEnergy -= Time.deltaTime * energyConsumptionSpeed;
        }

        if (DayNight.i.day)
        {
            flashlightEnergy += Time.deltaTime* rechargeSpeed;
        }
        gameUI.SetEnregy(flashlightEnergy);
    }

}
