using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intersection : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public Rigidbody car3;

    // Start is called before the first frame update
    void Start()
    {
        car1.SetActive(false);
        car2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            car3.constraints = RigidbodyConstraints.FreezeAll;
            car1.SetActive(true);
            car2.SetActive(true);
            car3.constraints = RigidbodyConstraints.None;
            StartCoroutine(wait());        

        }
    }

    IEnumerator wait()
    {
        car1.GetComponentInChildren<AI_CarEngine>().maxSpeed = 0;
        yield return new WaitForSeconds(3);
        car1.GetComponentInChildren<AI_CarEngine>().maxSpeed = 100;
        
    }
}
