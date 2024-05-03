using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The car to follow
    public Vector3 offset = new Vector3(4f, 2f, -5f); // The offset from the car
    public float smoothSpeed = 0.125f; // The smoothness of the camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = target.position - target.forward * offset.z + target.up * offset.y;
            
            // Smoothly move the camera to the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Make the camera look at the target
            transform.LookAt(target);
        }
    }
}
