using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;

public class StartAssigment : MonoBehaviour
{
    public Texture[] allColors;

    [SerializeField] GameObject[] grenzesColor;

    [SerializeField] ButtonHeadSnakeMoveScript leftMove;
    [SerializeField] ButtonHeadSnakeMoveScript rightMove;
    [SerializeField] CameraMoveScript cameraMove;
    [SerializeField] GameObject panelRestart;
    [SerializeField] StartPlayLvL startPlay;
    [SerializeField] TransitionNextLvL maxScore;
    [SerializeField] Text currentScore;

    [HideInInspector]
    public GameObject snake;

    private void Awake()
    {
        snake = Instantiate(PlayerSettings.currentSnake);
        snake.transform.position = new Vector3(0, 1f, -5.8f);

        snake.GetComponent<ClassSnake>().currentTail = Instantiate(snake.GetComponent<ClassSnake>().tailPrefab);

        Vector3 posTail = snake.transform.position;

        snake.GetComponent<ClassSnake>().body.Add(snake);
        snake.GetComponent<ClassSnake>().body.Add(snake.GetComponent<ClassSnake>().currentTail);

        BodyMoveScript bodyMoveTail = snake.GetComponent<ClassSnake>().currentTail.GetComponent<BodyMoveScript>();
        bodyMoveTail.followObject = snake;
        bodyMoveTail.currentSnake = snake.GetComponent<ClassSnake>();
        snake.GetComponent<ClassSnake>().currentTail.transform.position = new Vector3(posTail.x, posTail.y, posTail.z - 2f);

        cameraMove.position = snake.transform.GetChild(0).gameObject;
        
        ClassSnake classSnake = snake.GetComponent<ClassSnake>();
        SnakeMoveScript snakeMoveScript = snake.GetComponent<SnakeMoveScript>();
        BarrierScriptCollision barrierScriptCollision = snake.GetComponent<BarrierScriptCollision>();
        SnakeScore snakeScore = snake.GetComponent<SnakeScore>();
        startPlay.snake = classSnake;

        if (SceneManager.GetActiveScene().name != "InfLvL")
        {
            if(allColors.Length != 0)
            {
                classSnake.colorTexture = allColors[0];
            }
            else
            {
                classSnake.colorTexture = classSnake.standartTexture;
            }

            classSnake.meshRenderer.material.mainTexture = classSnake.colorTexture;
            classSnake.body[1].GetComponent<MeshRenderer>().material.mainTexture = classSnake.colorTexture;
        }

        leftMove.snake = snake;
        rightMove.snake = snake;

        snakeMoveScript.leftMove = leftMove;
        snakeMoveScript.rightMove = rightMove;

        barrierScriptCollision.panelRestartGame = panelRestart;

        if (grenzesColor.Length != 0)
        {
            for (int i = 0; i < grenzesColor.Length; i++)
            {
                if (grenzesColor[i].tag == "Flags")
                {
                    //grenzesColor[i].GetComponent<MeshRenderer>().material.mainTexture = allColors[i + 1];
                    grenzesColor[i].GetComponent<MeshRenderer>().materials[2].mainTexture = allColors[i + 1];
                }
                else
                {
                    grenzesColor[i].GetComponent<MeshRenderer>().material.mainTexture = allColors[i + 1];
                }
            }
        }

        if(CheatScriptPlayer.speed == speed.high)
        {
            classSnake.speed = 10f;
        }
        else if(CheatScriptPlayer.speed == speed.low)
        {
            classSnake.speed = 1f;
        }

        if(SceneManager.GetActiveScene().name != "InfLvL")
        {
            snakeScore.transitionNext = maxScore;
        }

        snakeScore.currentScore = currentScore;
    }
}