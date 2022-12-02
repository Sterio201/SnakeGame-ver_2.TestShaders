using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftInterfaceBlock : MonoBehaviour
{
    [SerializeField] GameObject currentBlock;
    [SerializeField] GameObject shiftBlock;

    [SerializeField] AudioSource audioSource;

    private void Start()
    {
        audioSource = GameObject.Find("SoundButtonManager").GetComponent<AudioSource>();
    }

    public void ShiftBlock()
    {
        if(audioSource != null) 
        {
            audioSource.Play();
        }

        if(currentBlock != null)
        {
            currentBlock.SetActive(false);
        }

        if (shiftBlock != null)
        {
            shiftBlock.SetActive(true);
        }
    }
}