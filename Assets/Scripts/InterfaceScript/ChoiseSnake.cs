using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseSnake : MonoBehaviour
{
    [SerializeField] ManagerSnake manager;
    [SerializeField] GameObject snake;
    [SerializeField] string nameFile;
    [SerializeField] GameObject imageClose;

    private void Start()
    {
        if(nameFile != "")
        {
            if (!PlayerPrefs.HasKey(nameFile))
            {
                imageClose.SetActive(true);
            }
        }
    }

    public void ButtonMethod()
    {
        manager.ShiftSnake(snake, GetComponent<Button>());
    }
}