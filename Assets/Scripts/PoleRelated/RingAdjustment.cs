using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAdjustment : MonoBehaviour
{
    [SerializeField] private GameObject ringsPrefab;
    [SerializeField] private GameObject lastRing;
    private GameObject[] ringArray;
    [SerializeField] private Vector3[] ringRotations;
    [SerializeField] private int ringDistance;
    [SerializeField] private int ringCount;

    private void Awake()
    {
        ringArray = new GameObject[ringCount];
        AdjustRingPositionAndRotation(ringRotations);
    }

    void AdjustRingPositionAndRotation(Vector3[] rotations)
    {
        for (int i = 0; i < ringCount; i++)
        {
            GameObject ring = Instantiate(ringsPrefab, transform);
            ringArray[i] = ring;
            int ringRotationIndex = Random.Range(0, rotations.Length);
            ringArray[i].transform.position = new Vector3(transform.position.x, i == 0 ? transform.position.y : ringArray[i - 1].transform.position.y - ringDistance, transform.position.z);
            ringArray[i].transform.rotation = Quaternion.Euler(0, rotations[ringRotationIndex].y, 0);
        }

        GameObject lastRingInstance = Instantiate(lastRing, transform);
        lastRingInstance.transform.position = new Vector3(transform.position.x, ringArray[ringCount - 1].transform.position.y - ringDistance, transform.position.z);
    }
}
