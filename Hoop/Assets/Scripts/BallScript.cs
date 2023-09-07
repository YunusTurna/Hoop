using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] private float forcePower = 10f;
    public bool camLock = false;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * forcePower * Time.deltaTime , ForceMode.Impulse);
        if(other.gameObject.tag != "nextHoop")
        {
            camLock = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "nextHoop")
        {
            camLock = true;
        }
        
    }
    
}
