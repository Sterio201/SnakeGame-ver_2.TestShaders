using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMoveScript : MonoBehaviour
{
    [HideInInspector]
    public GameObject followObject;

    [HideInInspector]
    public ClassSnake currentSnake;

    public void BodyMove()
    {
        followObject.transform.LookAt(followObject.transform);
        transform.position = Vector3.Lerp(transform.position, followObject.transform.position, Time.deltaTime * currentSnake.speed);
    }
}