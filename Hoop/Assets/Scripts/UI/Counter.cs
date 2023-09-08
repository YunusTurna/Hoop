using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{   
    BallScript bs;
    [SerializeField] private TextMeshProUGUI text;

    private void Start() {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
    }
    void Update()
    {
        text.text = "" + bs.score;
    }
}
