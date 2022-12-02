using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningMeteorFallAnimScript : MonoBehaviour
{
    [SerializeField] BlockAnimScript snake;
    [SerializeField] GameObject warningMeteor;
    bool anim;

    void ActivateAnim()
    {
        Transform posSnake = snake.snake.transform;

        GameObject newWarning = Instantiate(warningMeteor);
        Vector3 newWarningPosition = new Vector3(transform.position.x, posSnake.transform.position.y, transform.position.z);
        newWarning.transform.position = newWarningPosition;
    }
}