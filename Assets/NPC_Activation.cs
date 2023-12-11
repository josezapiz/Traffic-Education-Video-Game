using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Activation : MonoBehaviour
{
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        npc.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            npc.SetActive(true);
        }
    }
}
