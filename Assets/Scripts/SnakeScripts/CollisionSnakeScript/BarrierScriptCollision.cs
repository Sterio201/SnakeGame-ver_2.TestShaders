using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierScriptCollision : MonoBehaviour
{
    [HideInInspector]
    public GameObject panelRestartGame;

    [SerializeField] ClassSnake headSnake;
    [SerializeField] List<Sprite> spriteEnd;
    [SerializeField] List<string> nameBarrier;
    [SerializeField] List<AudioClip> audioClips;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        string coll = other.gameObject.tag;

        if (nameBarrier.Contains(coll) && !CheatScriptPlayer.inv)
        {
            if(coll != "fruit" || (coll == "fruit" && other.gameObject.transform.parent.gameObject.GetComponent<ColorEatScript>().colorEat != headSnake.colorTexture))
            {
                int id = nameBarrier.IndexOf(other.gameObject.tag);

                audioSource.clip = audioClips[id];
                audioSource.Play();
                //audioSource.clip = null;

                //Time.timeScale = 0f;
                headSnake.speed = 0f;

                Image imageBarrier = panelRestartGame.transform.GetChild(0).gameObject.GetComponent<Image>();
                imageBarrier.sprite = spriteEnd[id];

                panelRestartGame.SetActive(true);
            }
        }
    }
}