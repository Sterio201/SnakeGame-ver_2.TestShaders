using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    [SerializeField] GameObject panelEndGame;
    [SerializeField] Sprite sprite;

    [SerializeField] TransitionNextLvL transitionNext;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "snake")
        {
            ClassSnake snake = other.gameObject.GetComponent<ClassSnake>();
            transitionNext.snake = snake;

            string namePrefsScore = SceneManager.GetActiveScene().name + "_score";
            int lastScore = 0;
            if (PlayerPrefs.HasKey(namePrefsScore))
            {
                lastScore = PlayerPrefs.GetInt(namePrefsScore);
            }
            if (snake.currentScore > lastScore)
            {
                PlayerSettings.score += snake.currentScore - lastScore;

                PlayerPrefs.SetInt(namePrefsScore, snake.currentScore);
                PlayerPrefs.SetInt("score_player", PlayerSettings.score);
            }

            //Time.timeScale = 0f;
            snake.speed = 0f;

            Image image = panelEndGame.transform.GetChild(0).GetComponent<Image>();
            image.sprite = sprite;

            if(SceneManager.GetActiveScene().name == "LvL_5 Vulkan" && transitionNext.transitionScore <= snake.currentScore)
            {
                PlayerPrefs.SetString("endGame", "end");
            }

            if(SceneManager.GetActiveScene().name == "ShiftColorTraining" && transitionNext.transitionScore <= snake.currentScore)
            {
                PlayerPrefs.SetString("endTraining", "end");
                PlayerPrefs.DeleteKey("score_player");
            }

            panelEndGame.SetActive(true);
        }
    }
}