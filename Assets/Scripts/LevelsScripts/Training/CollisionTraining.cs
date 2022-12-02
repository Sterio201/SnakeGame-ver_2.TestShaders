using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTraining : MonoBehaviour
{
    [SerializeField] GameObject panelTraining;
    [SerializeField] Sprite spriteTraining;
    [SerializeField] string textTraining;

    ClassSnake snake;
    float currentSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "snake")
        {
            //snake = other.gameObject.GetComponent<ClassSnake>();
            //currentSpeed = snake.speed;
            //snake.speed = 0f;

            Time.timeScale = 0f;

            Image imageTraining = panelTraining.transform.GetChild(0).gameObject.GetComponent<Image>();
            imageTraining.sprite = spriteTraining;

            Text recom = panelTraining.transform.GetChild(2).gameObject.GetComponent<Text>();
            recom.text = textTraining;

            GameObject button = panelTraining.transform.GetChild(3).gameObject;
            //button.GetComponent<Continue>().speed = currentSpeed;

            panelTraining.SetActive(true);
        }
    }
}