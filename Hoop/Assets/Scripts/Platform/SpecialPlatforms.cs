using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPlatforms : MonoBehaviour
{
    BallScript bs;
    private GameObject ball;
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
        ball = GameObject.FindGameObjectWithTag("MainBall");
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
        if(this.gameObject.tag == "ExtraBall")
        {
            if(other.gameObject.tag == "MainBall")
            {
                Instantiate(ball, ball.transform.position, Quaternion.identity);
            }
        }

    }
}
