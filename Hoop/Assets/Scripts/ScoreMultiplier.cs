using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    BallScript bs;
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "ScoreReducer")
        {
            if (other.gameObject.tag == "MainBall" & bs.score > 5)
            {
                bs.score -= 5;
                
            }
        }
        if (this.gameObject.tag == "ScoreMultiplier")
        {
            if (other.gameObject.tag == "MainBall")
            {
                bs.score += 10;
            }
        }

    }
}
