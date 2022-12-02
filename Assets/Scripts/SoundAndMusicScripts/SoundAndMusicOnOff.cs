using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundAndMusicOnOff : MonoBehaviour
{
    [SerializeField] Type type;
    [SerializeField] AudioSource audioSource;

    [SerializeField] Image buttonImage;
    [SerializeField] Sprite on;
    [SerializeField] Sprite off;

    private void Start()
    {
        if (PlayerPrefs.HasKey(type.ToString()))
        {
            audioSource.volume = PlayerPrefs.GetFloat(type.ToString());
        }
        else
        {
            audioSource.volume = 1f;

            PlayerPrefs.SetFloat(type.ToString(), audioSource.volume);
        }

        if(audioSource.volume == 1f)
        {
            buttonImage.sprite = on;
        }
        else
        {
            buttonImage.sprite = off;
        }
    }

    public void OnOff()
    {
        string nameFile = type.ToString();
        float volume = 0f;

        if(PlayerPrefs.GetFloat(type.ToString()) == 0f)
        {
            volume = 1f;
        }
        else
        {
            volume = 0f;
        }

        SetVolume(volume);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        PlayerPrefs.SetFloat(type.ToString(), volume);

        if(volume > 0f)
        {
            buttonImage.sprite = on;
        }
        else if(volume == 0f)
        {
            buttonImage.sprite = off;
        }
    }
}

public enum Type {sound, music }