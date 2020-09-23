using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWood : MonoBehaviour
{
    public float addWoodTime = 1f;
    public float addTimer;
    public GameObject addWoodDisp;

    void Start()
    {
        addWoodDisp = GameObject.FindGameObjectWithTag("addWoodrepair");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          //  addWoodDisp.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                addTimer += Time.deltaTime;
                if(addTimer >= addWoodTime)
                {
                    
                    if (Resources.wood > 0)
                    {
                        Debug.Log("adding wood");
                        addTimer = 0;
                        GetComponentInParent<WoodBurning>().woodAmount++;
                        Resources.wood--;
                    }
                    else
                    {
                        Debug.Log("You are out of wood");
                    }
                }
            }

            if (Input.GetKey(KeyCode.R))
            {
                addTimer += Time.deltaTime;
                if (addTimer >= addWoodTime)
                {

                    if (GetComponentInParent<ObjectHealth>().currentHealth < GetComponentInParent<ObjectHealth>().health && Resources.wood > 0)
                    {
                        Debug.Log("Repaired");
                        addTimer = 0;
                        Resources.wood--;
                        GetComponentInParent<ObjectHealth>().currentHealth = GetComponentInParent<ObjectHealth>().health;
                    }
                    else
                    {
                        Debug.Log("You are out of wood or full health");
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            addWoodDisp.SetActive(false);
        }
    }
}
