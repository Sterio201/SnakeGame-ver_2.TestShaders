using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInterfaceScript : MonoBehaviour
{
    public AnimationClip clip;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play(clip.name);
    }
}