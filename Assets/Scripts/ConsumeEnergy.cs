using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeEnergy : MonoBehaviour
{
    public GameObject light;
    public int maxEnergy = 100;
    public float currentEnergy;

    public int consumptionRate = 2;
    public int rechargeRate = 1;

    public bool isOn;

    public ObjectUI objectUI;

    void Start()
    {
        currentEnergy = maxEnergy;
        objectUI.SetMaxEnergy(maxEnergy);

    }

    // Update is called once per frame
    void Update()
    {
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);

        if (isOn)
        {
            light.SetActive(true);
            currentEnergy -= Time.deltaTime * consumptionRate;
            objectUI.SetEnergy(currentEnergy);
        } else
        {
            light.SetActive(false);

        }

        if (DayNight.i.day)
        {
            currentEnergy += Time.deltaTime* rechargeRate;
            objectUI.SetEnergy(currentEnergy);
        }
    }
}
