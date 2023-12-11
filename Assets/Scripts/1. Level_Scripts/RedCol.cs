using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCol : MonoBehaviour
{
    public GameObject reset;
    // Start is called before the first frame update

    private void Start()
    {
        reset.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {

            Time.timeScale = 0;
            reset.SetActive(true);

        }

    }
}
