using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject light;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
               GetComponentInParent<ConsumeEnergy>().isOn = !GetComponentInParent<ConsumeEnergy>().isOn;
            }
        }
    }
}
