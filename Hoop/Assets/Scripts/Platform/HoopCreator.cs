using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] hoops;
    public GameObject basePoint, lastHoopObject, firstHoopObject;
    [SerializeField] private float hoopDistance = 2f;
    [SerializeField] private int numberOfHoops;
    private int randomNumber = 0;


    void Start()
    {
        HoopInstantiate();
        
    }

    void HoopInstantiate()
    {

        for (int i = 0; i < numberOfHoops; i++)
        {
            Vector3 spawnPosition = new Vector3(
                basePoint.transform.position.x,
                (basePoint.transform.position.y + 50) - i * hoopDistance,
                basePoint.transform.position.z
            );
            randomNumber = Random.Range(0, hoops.Length);
            if (i == 0)
            {
                GameObject lastHoop = Instantiate(firstHoopObject, new Vector3(spawnPosition.x, spawnPosition.y + hoopDistance, spawnPosition.z), Quaternion.identity);
                lastHoop.transform.parent = basePoint.transform;
            }
            if (i != numberOfHoops - -1)
            {
                GameObject newHoop = Instantiate(hoops[randomNumber], spawnPosition, Quaternion.identity);
                newHoop.transform.parent = basePoint.transform;
            }
            if (i == numberOfHoops - 1)
            {
                GameObject lastHoop = Instantiate(lastHoopObject, new Vector3(spawnPosition.x, spawnPosition.y - hoopDistance, spawnPosition.z), Quaternion.identity);
                lastHoop.transform.parent = basePoint.transform;

            }


        }



    }
    
}
