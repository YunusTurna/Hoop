using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50.0f;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        // Fare eksenlerinin hareketini al
        rotationX += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        

        // Nesneyi döndür
        transform.rotation = Quaternion.Euler(-rotationY, rotationX, 0);
    }
}
