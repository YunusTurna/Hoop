using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] hoops;
    [SerializeField] private GameObject basePoint;
    [SerializeField] private float hoopDistance = 2f; // 2 birimlik mesafe

    void Start()
    {
        HoopInstantiate();
    }

    void HoopInstantiate()
    {
        for (int i = 0; i < hoops.Length; i++)
        {
            Vector3 spawnPosition = new Vector3(
                basePoint.transform.position.x,
                basePoint.transform.position.y - i * hoopDistance, // Mesafeyi çarpanla artırın
                basePoint.transform.position.z
            );

            GameObject newHoop = Instantiate(hoops[i], spawnPosition, Quaternion.identity);
            newHoop.transform.parent = basePoint.transform;
        }
    }
}