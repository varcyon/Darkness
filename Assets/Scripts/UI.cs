using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public TextMeshProUGUI cycle;
    public TextMeshProUGUI dayNum;
    public TextMeshProUGUI metal;
    public TextMeshProUGUI wood;
    public TextMeshProUGUI batteries;
    public TextMeshProUGUI wiring;

    public Slider playerHealthSlider;
    public Slider energySlider;

    public GameObject winPanel;
    public GameObject losePanel;

    void Update()
    {
        if(DayNight.i.dayNum == 10)
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }


        metal.text = Resources.metal.ToString();
        wood.text = Resources.wood.ToString();
        batteries.text = Resources.batteries.ToString();
        wiring.text = Resources.wiring.ToString();

        if (DayNight.i.day)
        {
            cycle.text = "Day";
        }
        else if(DayNight.i.night){
            cycle.text = "Night";
        }

        dayNum.text = "Days survived: " + DayNight.i.dayNum;




    }
    public void SetMaxEnregy(float energy)
    {
        energySlider.maxValue = energy;
        energySlider.value = energy;
    }
    public void SetEnregy(float energy)
    {
        energySlider.value = energy;
    }
    public void SetMaxHealth(int health)
    {
        playerHealthSlider.maxValue = health;
        playerHealthSlider.value = health;
    }
    public void SetHealth(int health)
    {
        playerHealthSlider.value = health;
    }
}
