using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectButton : MonoBehaviour
{
    public GameObject continue_button;

    public void Correct()
    {
        this.GetComponent<Image>().color = Color.green;

        continue_button.SetActive(true);

    }


}
