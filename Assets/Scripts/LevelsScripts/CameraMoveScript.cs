using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    [HideInInspector]
    public GameObject position;

    public void LateUpdate()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, position.transform.position.z);

        transform.position = pos;
    }
}