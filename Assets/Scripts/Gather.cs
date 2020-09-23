using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum resourceTypes
{
    Batteries,
    Metal,
    Wood,
    Wiring

}
public class Gather : MonoBehaviour
{
    public resourceTypes resource;
    public int gatherAmount = 1;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (resource)
            {
                case resourceTypes.Batteries:
                    Resources.batteries += gatherAmount;
                    break;
                case resourceTypes.Metal:
                    Resources.metal += gatherAmount;
                    break;
                case resourceTypes.Wiring:
                    Resources.wiring += gatherAmount;
                    break;
                case resourceTypes.Wood:
                    Resources.wood += gatherAmount;
                    break;
            }
            Destroy(gameObject);
        }
    }
}
