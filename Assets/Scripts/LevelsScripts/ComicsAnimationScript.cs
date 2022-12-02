using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicsAnimationScript : MonoBehaviour
{
    [SerializeField] GameObject animScreen;
    [SerializeField] string tag;

    bool readyClose;

    private void Start()
    {
        readyClose = false;
        StartCoroutine(Ready());

        if(tag != "")
        {
            if (!PlayerPrefs.HasKey(tag))
            {
                animScreen.SetActive(true);
                animScreen.GetComponent<Animator>().Play("ComicsAnimation");
            }
            return;
        }

        animScreen.SetActive(true);
        animScreen.GetComponent<Animator>().Play("ComicsAnimation");
    }

    public void ConsideComics()
    {
        if (readyClose)
        {
            animScreen.SetActive(false);
        }
    }

    IEnumerator Ready()
    {
        yield return new WaitForSeconds(5f);
        readyClose = true;
    }
}