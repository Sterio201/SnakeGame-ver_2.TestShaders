using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftColorZoneInfLvLScript : MonoBehaviour
{
    private void Start()
    {
        if(gameObject.tag != "Flags")
        {
            gameObject.GetComponent<MeshRenderer>().material.mainTexture =
            PreferensInfinitiveLvL.currentTexture.RandomTexture(PreferensInfinitiveLvL.currentTexture.currentTexture);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().materials[2].mainTexture =
                PreferensInfinitiveLvL.currentTexture.RandomTexture(PreferensInfinitiveLvL.currentTexture.currentTexture);
        }
    }
}