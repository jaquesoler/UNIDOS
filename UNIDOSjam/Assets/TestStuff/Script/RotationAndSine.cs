using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndSine : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    void Update()
    {
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
