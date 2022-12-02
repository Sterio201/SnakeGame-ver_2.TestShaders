using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTextureInfLvLScript : MonoBehaviour
{
    [SerializeField] Texture[] allColorTextures;
    [SerializeField] StartAssigment startAssigment;

    [HideInInspector]
    public Texture currentTexture;

    private void Start()
    {
        currentTexture = RandomTexture();

        startAssigment.snake.GetComponent<ClassSnake>().meshRenderer.material.mainTexture = currentTexture;
        startAssigment.snake.GetComponent<ClassSnake>().colorTexture = currentTexture;
        startAssigment.snake.GetComponent<ClassSnake>().body[1].GetComponent<MeshRenderer>().material.mainTexture = currentTexture;

        PreferensInfinitiveLvL.currentTexture = this;
    }

    public Texture RandomTexture(Texture currentTexture)
    {
        int index = Array.IndexOf(allColorTextures, currentTexture);

        List<int> allIndex = new List<int>();
        for (int i = 0; i < allColorTextures.Length; i++)
        {
            allIndex.Add(i);
        }
        allIndex.Remove(index);

        int randomIndex = UnityEngine.Random.Range(0, allIndex.Count);

        return allColorTextures[allIndex[randomIndex]];
    }

    public Texture RandomTexture()
    {
        int randomIndex = UnityEngine.Random.Range(0, allColorTextures.Length);
        return allColorTextures[randomIndex];
    }
}