using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    [SerializeField] bool startPause;

    private void Start()
    {
        if (startPause)
        {
            PauseMove();
        }
    }

    public void PauseMove()
    {
        /*Debug.Log(snake.speed);
        speed = snake.speed;
        snake.speed = 0f;*/

        Time.timeScale = 0f;
    }

    public void ContinueMove()
    {
        /*if(speed != 0f)
        {
            snake.speed = speed;
            Debug.Log(snake.speed);
        }
        else
        {
            snake.speed = 4f;
        }*/

        Time.timeScale = 1f;
    }
}