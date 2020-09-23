using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    public List<GameObject> Craftables = new List<GameObject>();
    public List<int> craftTime = new List<int>();
    public List<int> craftCost = new List<int>();
    public float craftTimer;


    public GameObject backLight;
    public bool backlightCrafted;

    public Image fill;
    public float time;
    public float timerAmt;

    void Update()
    {
        if (backlightCrafted)
        {
            backLight.SetActive(true);
        }

        //craft small camp fire
        if (Input.GetKey(KeyCode.Alpha1))
        {

            if (Resources.wood >= craftCost[0])
            {

                craftTimer += Time.deltaTime;
                fill.fillAmount = craftTimer / craftTime[0];
                if (craftTimer > craftTime[0])
                {
                    craftTimer = 0;
                    Instantiate(Craftables[0], transform.position, Quaternion.identity);
                    Resources.wood -= craftCost[0];
                }
            }
            else
            {
                Debug.Log("Not enough wood to craft");
            }
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            fill.fillAmount = 0;

        }
        //craft bon fire
        if (Input.GetKey(KeyCode.Alpha2))
        {

            if (Resources.wood >= craftCost[1])
            {
                craftTimer += Time.deltaTime;
                fill.fillAmount = craftTimer / craftTime[1];

                if (craftTimer > craftTime[1])
                {
                    craftTimer = 0;
                    Instantiate(Craftables[1], transform.position, Quaternion.identity);
                    Resources.wood -= craftCost[1];

                }
            }
            else
            {
                Debug.Log("Not enough wood to craft");
            }
        }

        // Craft SolarPowered
        if (Input.GetKey(KeyCode.Alpha3))
        {

            if (Resources.metal >= 10 && Resources.wiring >= 5 && Resources.batteries >= 2)
            {
                craftTimer += Time.deltaTime;
                fill.fillAmount = craftTimer / craftTime[2];

                if (craftTimer > craftTime[2])
                {
                    craftTimer = 0;
                    Instantiate(Craftables[2], transform.position+ new Vector3(2,2,2), Quaternion.identity);
                    Resources.metal -= 10;
                    Resources.wiring -= 5;
                    Resources.batteries -= 2;

                }

            }
        }

        // Craft back light
        if (Input.GetKey(KeyCode.Alpha4))
        {

            if (Resources.metal >= 5 && Resources.wiring >= 2 && Resources.batteries >= 2)
            {
                craftTimer += Time.deltaTime;
                fill.fillAmount = craftTimer / craftTime[3];

                if (craftTimer > craftTime[3])
                {
                    craftTimer = 0;
                    backlightCrafted = true;
                    Resources.metal -= 5;
                    Resources.wiring -= 2 ;
                    Resources.batteries -= 2;

                }

            }
        }


    }
}
