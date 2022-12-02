using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorEatScript : MonoBehaviour
{
    [SerializeField] StartAssigment startAssigment;
    [SerializeField] bool kostilForInfLvL;
    [SerializeField] int nomerColor;

    [HideInInspector]
    public Texture colorEat;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name != "InfLvL")
        {
            colorEat = startAssigment.allColors[nomerColor];
        }
        else
        {
            if (kostilForInfLvL)
            {
                colorEat = PreferensInfinitiveLvL.currentTexture.currentTexture;
            }
            else
            {
                colorEat = PreferensInfinitiveLvL.currentTexture.RandomTexture
                    (PreferensInfinitiveLvL.currentTexture.currentTexture);
            }
        }

        gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = colorEat;
    }
}