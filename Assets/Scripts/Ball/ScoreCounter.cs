using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;
    private int scoreMultiplier = 2;



    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "MultiplyScore":
                score = score * 2;
                scoreText.text = score.ToString();
                Destroy(other.gameObject);
                break;
            case "AddScore":
                score = score + 10;
                scoreText.text = score.ToString();
                Destroy(other.gameObject);
                break;

            default:
            ScoreCounterMethod();
                break;
        }
    }
    private void ScoreCounterMethod()
    {
        scoreText.text = "Score: 0";
        score++;
        scoreText.text = score.ToString();
    }

}
