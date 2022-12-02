using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabling : MonoBehaviour
{
    [SerializeField] GameObject curPlatform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "snake") 
        {
            curPlatform.SetActive(false);
        }
    }
}