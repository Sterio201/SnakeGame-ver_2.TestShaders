using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayLvL : MonoBehaviour
{
    [HideInInspector] public ClassSnake snake;
    float speed; 

    private void Start()
    {
        speed = snake.speed;
        snake.speed = 0f;
    }

    public void TapToStart()
    {
        snake.speed = speed;
        gameObject.SetActive(false);
    }
}