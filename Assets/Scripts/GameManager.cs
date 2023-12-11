using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public InputController InputController { get; private set; }

    public GameObject congratulations;
    public GameObject Welcome;


    public void CompleteLevel()
    {
        congratulations.SetActive(true);
    }

    void Awake()
    {
        congratulations.SetActive(false);
        Instance = this;
        InputController = GetComponentInChildren<InputController>();


        Welcome.SetActive(true);
        Time.timeScale = 0;



    }
}
