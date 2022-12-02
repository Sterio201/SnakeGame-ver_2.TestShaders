using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMoveScript : MonoBehaviour
{
    [SerializeField] ClassSnake snake;
    Rigidbody rb;

    [HideInInspector]
    public ButtonHeadSnakeMoveScript leftMove;
    [HideInInspector]
    public ButtonHeadSnakeMoveScript rightMove;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if(snake.speed != 0f)
        {
            Vector3 tempVect = new Vector3(0, 0, 1);
            tempVect = tempVect.normalized * snake.speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);

            leftMove.MoveSideWays();
            rightMove.MoveSideWays();

            if (snake.body.Count > 1)
            {
                for (int i = 1; i < snake.body.Count; i++)
                {
                    snake.body[i].GetComponent<BodyMoveScript>().BodyMove();
                }
            }

            RotationFix();
        }
    }

    void RotationFix()
    {
        if (transform.rotation.y != 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}