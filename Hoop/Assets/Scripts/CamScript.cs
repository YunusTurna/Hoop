using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    BallScript bs;
    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bs.camLock == true)
        {
            this.gameObject.transform.parent = GameObject.FindGameObjectWithTag("MainBall").transform;
        }
        else
        {
            this.gameObject.transform.parent = null;
        }
    }
}
