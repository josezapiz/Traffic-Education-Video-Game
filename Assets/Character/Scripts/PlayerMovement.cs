using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform path;
    private List<Transform> nodes;
    private int currentNode = 0;
    public GameObject res;
    void Start()
    {
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != path.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }
    }

    private void FixedUpdate()
    {
        Walk();

        CheckWaypointDistance();
    }

    private void Walk()
    {
        transform.LookAt(nodes[currentNode].position);
        transform.position = Vector3.MoveTowards(transform.position, nodes[currentNode].position, 0.02f);
    }

    private void CheckWaypointDistance()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < 1.5f)
        {
            if (currentNode == nodes.Count - 1)
            {
                currentNode = 0;
            }
            else
            {
                currentNode++;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            res.SetActive(true);
            Time.timeScale = 0;
        }

    }

}
