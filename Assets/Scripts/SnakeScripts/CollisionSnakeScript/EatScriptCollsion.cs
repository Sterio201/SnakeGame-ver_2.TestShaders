using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EatScriptCollsion : MonoBehaviour
{
    [SerializeField] ClassSnake snake;
    [SerializeField] SnakeScore snakeScore;
    [SerializeField] AnimationClip clipEat;
    [SerializeField] AudioClip audio;
    AudioSource audioSource;

    BodyMoveScript moveTail;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "fruit")
        {
            StartCoroutine(DisappearEat(other.gameObject));

            ColorEatScript classEat = other.gameObject.transform.parent.gameObject.GetComponent<ColorEatScript>();

            Collider coll = other.gameObject.GetComponent<Collider>();
            coll.enabled = false;

            if (snake.colorTexture == classEat.colorEat)
            {
                gameObject.GetComponent<Animator>().Play(clipEat.name);

                if(CheatScriptPlayer.speed == speed.no)
                {
                    snake.speed += 0.2f;
                }

                if(snake.body.Count < 5)
                {
                    CreateNewBody(snake.body[snake.body.Count - 2], snake);
                    moveTail = snake.body[snake.body.Count - 1].GetComponent<BodyMoveScript>();
                    moveTail.followObject = snake.body[snake.body.Count - 2];
                    moveTail.gameObject.transform.position = new Vector3(moveTail.gameObject.transform.position.x, moveTail.gameObject.transform.position.y, moveTail.gameObject.transform.position.z - 2.4f);
                }

                snake.currentScore++;
                if(SceneManager.GetActiveScene().name != "InfLvL")
                {
                    if (snake.currentScore <= snakeScore.transitionNext.transitionScore)
                    {
                        snakeScore.Addition(snake.currentScore);
                    }
                }
                else
                {
                    snakeScore.Addition(snake.currentScore);
                }
            }
        }
    }

    void CreateNewBody(GameObject lastPartSnake, ClassSnake currentSnake)
    {
        Vector3 positionNewSnake = new Vector3(lastPartSnake.transform.position.x, lastPartSnake.transform.position.y, lastPartSnake.transform.position.z - 2f);
        GameObject newPartSnake = Instantiate(currentSnake.bodyPart, positionNewSnake, Quaternion.identity);
        newPartSnake.transform.SetParent(currentSnake.gameObject.transform.parent);
        newPartSnake.GetComponent<MeshRenderer>().material.mainTexture = currentSnake.colorTexture;

        BodyMoveScript bodyMoveScript = newPartSnake.GetComponent<BodyMoveScript>();
        bodyMoveScript.followObject = lastPartSnake;
        bodyMoveScript.currentSnake = currentSnake;

        currentSnake.body.Insert(currentSnake.body.Count - 1, bodyMoveScript.gameObject);
    }

    IEnumerator DisappearEat(GameObject eat)
    {
        audioSource.clip = audio;
        audioSource.Play();
        //audioSource.clip = null;

        Animator anim = eat.GetComponent<Animator>();
        anim.Play("EatDestroy");

        yield return new WaitForSeconds(0.3f);
        eat.gameObject.SetActive(false);
    }
}