using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHeadSnakeMoveScript : MonoBehaviour
{
    [HideInInspector]
    public GameObject snake;
    Rigidbody rb;
    ClassSnake snakeClass;

    [SerializeField] int direction;

    bool isHeldDown = false;

    public void OnPress()
    {
        isHeldDown = false;
        rb.velocity = Vector3.zero;
    }

    public void OnRelease()
    {
        isHeldDown = true;
    }

    private void Start()
    {
        rb = snake.GetComponent<Rigidbody>();
        snakeClass = snake.GetComponent<ClassSnake>();
    }

    public void MoveSideWays()
    {
        if (isHeldDown)
        {
            Vector3 tempVect = new Vector3(direction, 0, 0);
            tempVect *= snakeClass.speedTurn;

            rb.velocity = tempVect;   
        }
    }
}