using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class WoodBurning : MonoBehaviour
{
    public int woodAmount = 5;
    public int burnTime = 60;
    public float burnTimer;
    public GameObject light;

    public TextMeshProUGUI woodAmountDisp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(woodAmount <= 0)
        {
            light.SetActive(false);
        }else
        {
            light.SetActive(true);
            burnTimer += Time.deltaTime;
            if( burnTimer > burnTime)
            {
                burnTimer = 0;
                woodAmount--;
            }
        }

        woodAmountDisp.text = woodAmount.ToString();
    }
}
