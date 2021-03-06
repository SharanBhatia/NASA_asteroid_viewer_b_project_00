using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotations : MonoBehaviour
{
    public float rotSpeed = 20;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.RotateAround(Vector3.up, -rotX);
            transform.RotateAround(Vector3.right, -rotY);
        }
    }
}