using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    BallScript bs;
    [SerializeField] private GameObject ball;
    [SerializeField] private float chaseSpeed;

    void Start()
    {
        bs = GameObject.FindGameObjectWithTag("MainBall").GetComponent<BallScript>();
    }

    void FixedUpdate()
    {
        if (bs.camLock == true)
        {
            // Kameranın yeni pozisyonunu hesapla
            Vector3 targetPosition = new Vector3(transform.position.x, ball.transform.position.y + 5, transform.position.z);
            
            // Kamerayı yeni pozisyona doğru belirli bir hızda hareket ettir
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, chaseSpeed * Time.deltaTime);
        }
        else
        {
            // Eğer camLock false ise kameranın ebeveynini null yap
            this.gameObject.transform.parent = null;
        }
    }
}
