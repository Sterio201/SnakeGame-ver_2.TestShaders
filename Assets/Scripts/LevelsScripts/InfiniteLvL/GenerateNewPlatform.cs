using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewPlatform : MonoBehaviour
{
    [SerializeField] GameObject curPlatform;
    [SerializeField] Transform positionGenerate;
    [SerializeField] GameObject shiftColor;

    Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "snake")
        {
            GameObject newPlatform;
            Vector3 oldPos;
            
            if(shiftColor.tag != "Flags")
            {
                PreferensInfinitiveLvL.currentTexture.currentTexture = shiftColor.GetComponent<MeshRenderer>().material.mainTexture;
            }
            else
            {
                PreferensInfinitiveLvL.currentTexture.currentTexture = shiftColor.GetComponent<MeshRenderer>().materials[2].mainTexture;
            }

            newPlatform = Instantiate(PreferensInfinitiveLvL.platformPool.RandomPlatform());
            Transform longNewPlatform = newPlatform.transform.GetChild(0);

            oldPos = curPlatform.transform.position;
            newPlatform.transform.position = new Vector3(oldPos.x, oldPos.y, oldPos.z + (positionGenerate.localScale.z/2) + (longNewPlatform.localScale.z/2));
            animator = newPlatform.GetComponent<Animator>();
            animator.Play("PlatformAnimShow");
        }
    }
}