using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReducer : MonoBehaviour
{
    BallScript bs;
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "MainBall")
        {
            bs.score /= 2;
        }
    }
}
