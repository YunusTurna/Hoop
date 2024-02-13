using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("RingPart"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
