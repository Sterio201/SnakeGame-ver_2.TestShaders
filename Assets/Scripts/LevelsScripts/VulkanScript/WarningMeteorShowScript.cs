using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningMeteorShowScript : MonoBehaviour
{
    [SerializeField] AnimationClip clip;

    [System.Obsolete]
    private void Start()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.Play(clip.name);

        //Debug.Log(animator.Get);

        Destroy(gameObject, clip.length);
    }
}