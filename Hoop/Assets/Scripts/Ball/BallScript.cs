using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    Rigidbody rb;
    HoopCreator hp;
    [SerializeField] private float forcePower = 10f;
    [SerializeField] private GameObject newBall;
    
    
    public bool camLock = false;

    public int score = 0;
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        hp = GameObject.FindGameObjectWithTag("Platform").GetComponent<HoopCreator>();
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
        if(other.gameObject.tag == "Score")
        {
            score++;
        }
        if(this.gameObject.tag == "MainBall")
        {
            if(other.gameObject.tag == "ExtraBall")
            {
                
                 GameObject cloneBall = Instantiate(newBall, this.gameObject.transform.position, Quaternion.identity);
                 
            }
        }
        
    }
    
}
