using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrioSign : MonoBehaviour
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
            StartCoroutine(wait());

        }
    }

    IEnumerator wait()
    {
        car.GetComponentInChildren<AI_CarEngine>().maxSpeed = 0;
        yield return new WaitForSeconds(4);
        car.GetComponentInChildren<AI_CarEngine>().maxSpeed = 100;

    }
}
