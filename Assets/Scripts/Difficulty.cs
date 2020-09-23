using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Difficulty : MonoBehaviour
{
    public List<GameObject> spawnMounds = new List<GameObject>();
    public GameObject player;
    void Start()
    {
        spawnMounds = spawnMounds.OrderBy(player => Vector3.Distance(this.transform.position, player.transform.position)).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        switch (DayNight.i.dayNum)
        {
            case 0:
                for(int i = 0; i < 1; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;

            case 1:
                for (int i = 0; i < 3; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 2:
                for (int i = 0; i < 4; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 3:
                for (int i = 0; i < 5; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 4:
                for (int i = 0; i < 6; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 5:
                for (int i = 0; i < 7; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 6:
                for (int i = 0; i < 9; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 7:
                for (int i = 0; i < 11; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 8:
                for (int i = 0; i < 13; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 9:
                for (int i = 0; i < 15; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;
            case 10:
                for (int i = 0; i < 16; i++)
                {
                    spawnMounds[i].SetActive(true);
                }
                break;

        }
    }
}
