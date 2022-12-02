using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSnake : MonoBehaviour
{
    public Button currentButton;

    private void Start()
    {
        currentButton.interactable = false;
    }

    public void ShiftSnake(GameObject newSnake, Button newButton)
    {
        currentButton.interactable = true;
        newButton.interactable = false;
        currentButton = newButton;
        PlayerSettings.currentSnake = newSnake;
    }
}