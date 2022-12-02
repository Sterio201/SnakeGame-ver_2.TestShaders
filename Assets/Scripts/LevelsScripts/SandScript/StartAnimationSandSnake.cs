using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationSandSnake : MonoBehaviour
{
    [SerializeField] AnimationClip clip;

    private void Start()
    {
        Animator animator = gameObject.GetComponent<Animator>();

        animator.Play(clip.name);
    }
}