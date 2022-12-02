using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScriptCollision : MonoBehaviour
{
    [SerializeField] GameObject lava;
    [SerializeField] AnimationClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rood")
        {
            GameObject newLava = Instantiate(lava);
            newLava.transform.position = transform.position;

            newLava.transform.parent = gameObject.transform.parent.parent;

            Animator animLava = newLava.GetComponent<Animator>();
            animLava.Play("LavaShow");

            StartCoroutine(DestroyTime());
        }
    }

    IEnumerator DestroyTime()
    {
        Animator animator = GetComponent<Animator>();
        animator.Play(clip.name);

        yield return new WaitForSeconds(1.1f);

        gameObject.SetActive(false);
    }
}