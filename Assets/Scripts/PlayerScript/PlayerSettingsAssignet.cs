using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettingsAssignet : MonoBehaviour
{
    [SerializeField] GameObject[] allSnake;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();

        CheatScriptPlayer.inv = false;
        CheatScriptPlayer.speed = speed.no;

        if (PlayerPrefs.HasKey("currentSnake"))
        {
            string nameCurrentSnake = PlayerPrefs.GetString("currentSnake");
            ClassSnake classSnake = new ClassSnake();

            for(int i = 0; i<allSnake.Length; i++)
            {
                classSnake = allSnake[i].GetComponent<ClassSnake>();
                if(nameCurrentSnake == classSnake.nameSnake)
                {
                    PlayerSettings.currentSnake = allSnake[i];
                    break;
                }
            }
        }
        else
        {
            PlayerSettings.currentSnake = allSnake[0];
        }

        if (PlayerPrefs.HasKey("score_player"))
        {
            PlayerSettings.score = PlayerPrefs.GetInt("score_player");
        }
        else
        {
            PlayerSettings.score = 0;
        }

        PlayerSettings.reclam = new ReclamClass();
        PlayerSettings.reclam.countLoose = 0;

        //Debug.Log(PlayerSettings.currentSnake.GetComponent<ClassSnake>().nameSnake);
    }
}