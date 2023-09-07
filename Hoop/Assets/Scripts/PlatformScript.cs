using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    
    [SerializeField] private float rotationSpeed = 50.0f; 

    void Update()
    {
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateObject(Vector3.up);
        }

        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateObject(Vector3.down);
        }
    }

    
    void RotateObject(Vector3 direction)
    {
        
        transform.Rotate(direction * rotationSpeed * Time.deltaTime);
    }
}
