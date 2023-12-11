using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public GameObject flashL;
    public GameObject flashR;
    private bool left;
    private bool right;
    private int q;
    private int e;


    // Start is called before the first frame update
    void Start()
    {
        flashL.SetActive(false);
        flashR.SetActive(false);

        left = false;
        q = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            q++;
            left = true;
            StartCoroutine(Left_flash_on());
        }

        if (Input.GetKeyDown("e"))
        {
            e++;
            right = true;
            StartCoroutine(Right_flash_on());
        }

    }

    IEnumerator Left_flash_on()
    {

        while (left && q % 2 != 0)
        {
            flashL.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            flashL.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    IEnumerator Right_flash_on()
    {
        while (right && e % 2 != 0)
        {
            flashR.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            flashR.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }

    }

}
