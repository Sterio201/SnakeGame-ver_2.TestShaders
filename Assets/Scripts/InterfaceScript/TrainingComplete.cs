using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingComplete : MonoBehaviour
{
    public string tagComplete;

    public GameObject training;
    public GameObject trainingComplete;

    private void OnEnable()
    {
        if(tagComplete != "")
        {
            if (PlayerPrefs.HasKey(tagComplete))
            {
                if(trainingComplete != null)
                {
                    trainingComplete.SetActive(true);
                }
            }
            else
            {
                if(training != null)
                {
                    training.SetActive(true);
                }
            }
        }
    }
}