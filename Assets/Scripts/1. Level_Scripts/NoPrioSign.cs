using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPrioSign : MonoBehaviour
{
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        car.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            car.SetActive(true);
        }
    }
}
