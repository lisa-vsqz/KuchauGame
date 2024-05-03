using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 5f; // Speed of the car
    public float rotationSpeed = 100f; // Rotation speed of the car

    void Update()
    {
        float translation = -Input.GetAxis("Vertical") * speed * Time.deltaTime; // Invert the translation
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(translation, 0f, 0f);
        transform.Rotate(0f, 0f, rotation);
    }
}