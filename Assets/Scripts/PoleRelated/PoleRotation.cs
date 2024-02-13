using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Fare girişi için
        if (Input.GetMouseButton(0)) 
        {
            float mouseX = Input.GetAxis("Mouse X");
            RotatePole(new Vector3(0, -mouseX, 0));
        }

        // Dokunmatik girişi için
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float touchDeltaX = touch.deltaPosition.x;
                RotatePole(new Vector3(0, -touchDeltaX, 0));
            }
        }
    }

    void RotatePole(Vector3 rotation)
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
