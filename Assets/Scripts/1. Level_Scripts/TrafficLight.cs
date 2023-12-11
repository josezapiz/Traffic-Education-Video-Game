using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public GameObject Red;
    public GameObject Yellow;
    public GameObject Green;

    public GameObject WalkRed1;
    public GameObject WalkGreen1;

    public GameObject WalkRed2;
    public GameObject WalkGreen2;

    public GameObject red_col;

    public GameObject Pedestrian;

    public GameObject Taxi;

    // Start is called before the first frame update
    void Start()
    {
        Red.SetActive(false);
        Yellow.SetActive(false);
        Green.SetActive(true);
        WalkRed1.SetActive(true);
        WalkGreen1.SetActive(false);
        WalkRed2.SetActive(true);
        WalkGreen2.SetActive(false);
        red_col.SetActive(false);

        Pedestrian.SetActive(false);
        Taxi.SetActive(false);
    }

    private void Update()
    {
        if(Red.activeSelf)
        {
            red_col.SetActive(true);
        }
        else
        {
            red_col.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            StartCoroutine(wait());
        }

        IEnumerator wait()
        {
            Green.SetActive(false);
            Yellow.SetActive(true);
            yield return new WaitForSeconds(3);
            Yellow.SetActive(false);
            Red.SetActive(true);
            WalkGreen1.SetActive(true);
            WalkRed1.SetActive(false);
            WalkGreen2.SetActive(true);
            WalkRed2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            Taxi.SetActive(true);
            Pedestrian.SetActive(true);
            yield return new WaitForSeconds(8);
            WalkGreen1.SetActive(false);
            WalkRed1.SetActive(true);
            WalkGreen2.SetActive(false);
            WalkRed2.SetActive(true);
            yield return new WaitForSeconds(2);
            Red.SetActive(false);
            Green.SetActive(true);
        }
    }

}
