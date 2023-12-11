using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_CarEngine : MonoBehaviour
{

    public Transform path;
    public float maxSteerAngle = 45f;
    public WheelCollider WheelLeftFront;
    public WheelCollider WheelRightFront;

    public float maxMotorTorque = 80f;
    public float currentSpeed;
    public float maxSpeed = 100f;

    private List<Transform> nodes;
    private int currentNode = 0;

    void Start()
    {
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for(int i=0; i<pathTransforms.Length; i++)
        {
            if(pathTransforms[i] != path.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }
    }

    private void FixedUpdate()
    {
        ApplySteer();

        Drive();

        CheckWaypointDistance();

    }

    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        relativeVector /= relativeVector.magnitude;

        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;

        WheelLeftFront.steerAngle = newSteer;
        WheelRightFront.steerAngle = newSteer;
    }

    private void Drive()
    {
        currentSpeed = 2 * Mathf.PI * WheelLeftFront.radius * WheelLeftFront.rpm * 60 / 1000;

        if (currentSpeed < maxSpeed)
        {
            WheelLeftFront.motorTorque = 1500f;
            WheelRightFront.motorTorque = 1500f;
        }
        else
        {
            WheelLeftFront.motorTorque = 0;
            WheelRightFront.motorTorque = 0;
        }
    }

    private void CheckWaypointDistance()
    {
        if(Vector3.Distance(transform.position, nodes[currentNode].position) < 2f)
        {
            if(currentNode == nodes.Count - 1)
            {
                currentNode = 0;
            }
            else
            {
                currentNode++;
            }

        }
    }
}
