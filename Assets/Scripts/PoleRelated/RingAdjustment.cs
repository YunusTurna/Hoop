using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAdjustment : MonoBehaviour
{
    [SerializeField] private GameObject polePrefab;
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

    private void Start()
    {
        AdjustPoleScale();
    }

    void AdjustRingPositionAndRotation(Vector3[] rotations)
    {
        for (int i = 0; i < ringCount - 1; i++)
        {
            GameObject ring = Instantiate(ringsPrefab, transform);
            ringArray[i] = ring;
            int ringRotationIndex = Random.Range(0, rotations.Length);
            ringArray[i].transform.position = new Vector3(transform.position.x, i == 0 ? transform.position.y : ringArray[i - 1].transform.position.y - ringDistance, transform.position.z);
            ringArray[i].transform.rotation = Quaternion.Euler(0, rotations[ringRotationIndex].y, 0);
        }

        // Instantiate the last ring
        lastRing = Instantiate(lastRing, transform);
        ringArray[ringCount - 1] = lastRing;
        int lastRingRotationIndex = Random.Range(0, rotations.Length);
        lastRing.transform.position = new Vector3(transform.position.x, ringArray[ringCount - 2].transform.position.y - ringDistance, transform.position.z);
        lastRing.transform.rotation = Quaternion.Euler(0, rotations[lastRingRotationIndex].y, 0);
    }

    void AdjustPoleScale()
    {
        for (int i = 0; i < ringCount; i++)
        {
            ringArray[i].transform.parent = null;
        }

        polePrefab.transform.localScale = new Vector3(polePrefab.transform.localScale.x, ringArray[0].transform.position.y - ringArray[ringArray.Length - 1].transform.position.y, polePrefab.transform.localScale.z);
        polePrefab.transform.position = new Vector3(polePrefab.transform.position.x, polePrefab.transform.position.y - (polePrefab.transform.localScale.y / 2), polePrefab.transform.position.z);

        for (int i = 0; i < ringCount; i++)
        {
            ringArray[i].transform.parent = polePrefab.transform;
        }
    }
}
