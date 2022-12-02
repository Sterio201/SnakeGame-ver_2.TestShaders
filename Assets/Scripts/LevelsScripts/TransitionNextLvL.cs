using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionNextLvL : MonoBehaviour
{
    public int transitionScore;
    [SerializeField] GameObject panelNotTransition;

    [HideInInspector] public ClassSnake snake;

    public void TransitionNextLvLFun()
    {
        if(snake.currentScore >= transitionScore)
        {
            int currentIndexLvL = SceneManager.GetActiveScene().buildIndex;
            int allCountScene = SceneManager.sceneCountInBuildSettings;

            if((currentIndexLvL+1) < allCountScene)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(currentIndexLvL + 1);
            }
            else
            {
                SceneManager.LoadScene("StartScene");
            }
        }
        else
        {
            panelNotTransition.SetActive(true);
        }
    }
}