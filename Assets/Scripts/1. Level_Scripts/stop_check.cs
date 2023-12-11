using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop_check : MonoBehaviour
{
    
    public GameObject question;
    public GameObject cont;
    public GameObject res;
    private bool triggered_once;
    
    // Start is called before the first frame update
    void Start()
    {
        question.SetActive(false);
        cont.SetActive(false);
        res.SetActive(false);
        triggered_once = true;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7 && triggered_once == true)
        {
            Time.timeScale = 0;

            question.SetActive(true);

            triggered_once = false;
        }
    }
}
