using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongButton : MonoBehaviour
{
    public GameObject Panel;
    public GameObject CorrectButton;
    public GameObject Restart_button;

    public void Wrong()
    {
        this.GetComponent<Image>().color = Color.red;
        CorrectButton.GetComponent<Image>().color = Color.green;

        Restart_button.SetActive(true);
    }
}