using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject Panel;
    public void Continue_button()
    {
        Time.timeScale = 1;
        Destroy(Panel);
    }
}
