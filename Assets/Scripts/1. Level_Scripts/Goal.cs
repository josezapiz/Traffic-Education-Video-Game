using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{


    public GameManager gameManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            gameManager.CompleteLevel();
            StartCoroutine(wait());
            
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
