using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAndCloseLvL : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameObject lockIcon;
    [SerializeField] GameObject lockText;
    [SerializeField] int sizeOpen;

    private void Start()
    {
        if(PlayerSettings.score < sizeOpen)
        {
            lockIcon.SetActive(true);

            if(lockText != null)
            {
                Text text = lockText.GetComponent<Text>();
                text.text = "Для перехода не хватает " + (sizeOpen - PlayerSettings.score) + " очков";
                lockText.SetActive(true);
            }

            button.interactable = false;
        }
    }
}