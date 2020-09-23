using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Freeze", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Freeze()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
