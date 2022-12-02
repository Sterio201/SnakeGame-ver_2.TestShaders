using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAnimScript : MonoBehaviour
{
    [SerializeField] float distanceActivate;
    [SerializeField] AnimationClip clip;

    //[HideInInspector]
    public GameObject snake;

    [SerializeField] GameObject BlockBody;
    bool anim;

    Animator animator;

    private void Start()
    {
        snake = GameObject.FindWithTag("snake");

        animator = BlockBody.GetComponent<Animator>();

        //Debug.Log(snake.GetComponent<ClassSnake>().nameSnake);
    }

    private void LateUpdate()
    {
        if (!anim)
        {
            if (transform.position.z - snake.transform.position.z < distanceActivate)
            {
                BlockBody.SetActive(true);

                animator.Play(clip.name);
                anim = true;
                //Debug.Log(anim);
            }
        }
        else
        {
            if (snake.GetComponent<ClassSnake>().speed == 0f)
            {
                animator.enabled = false;
            }
        }
    }
}