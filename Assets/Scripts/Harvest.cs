using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
    public int harvestAmount = 10;
    public int harvestTime = 1;
    public float harvestTimer;
    public GameObject harvestDisp;

     void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            harvestDisp.SetActive(true);
            Debug.Log("can harvest");
            if (Input.GetKey(KeyCode.F))
            {
                other.GetComponent<FlashLight>().flashlight.SetActive(false);
                other.GetComponent<FlashLight>().isOn = false;
                Debug.Log("harvesting");
                harvestTimer += Time.deltaTime;
                if (harvestTimer >= harvestTime)
                {
                    Resources.wood += harvestAmount;
                    Destroy(gameObject);
                    harvestDisp.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        harvestDisp.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
