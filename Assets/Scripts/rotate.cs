using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    // Rotation speed in degrees per second
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Z axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}


