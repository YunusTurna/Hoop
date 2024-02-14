using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10f;
    private void OnCollisionEnter(Collision other)
    {
        
            GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        
    }
}
