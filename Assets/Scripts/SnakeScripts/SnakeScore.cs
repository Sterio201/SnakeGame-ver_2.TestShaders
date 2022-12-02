using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnakeScore : MonoBehaviour
{
    [HideInInspector]
    public TransitionNextLvL transitionNext;

    [HideInInspector] public Text currentScore;
    int maxScore;

    private void Start()
    {
        if (transitionNext != null)
        {
            currentScore.text = "0";
        }

        if (SceneManager.GetActiveScene().name != "InfLvL")
        {
            maxScore = transitionNext.transitionScore;
            currentScore.text += "/" + maxScore.ToString();
        }
    }

    public void Addition(int score)
    {
        currentScore.text = score.ToString() + " / " + maxScore;
    }
}