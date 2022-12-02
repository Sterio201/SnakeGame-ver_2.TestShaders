using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPoolScript : MonoBehaviour
{
    [SerializeField] GameObject[] prefabPlatformMass;

    private void Start()
    {
        GameObject firstPlatform = Instantiate(RandomPlatform());
        Vector3 firstPos = new Vector3(0, 0, 9);

        firstPlatform.transform.position = firstPos;

        PreferensInfinitiveLvL.platformPool = this;
    }

    public GameObject RandomPlatform()
    {
        int randomIndex = UnityEngine.Random.Range(0, prefabPlatformMass.Length);
        return prefabPlatformMass[randomIndex];
    }
}