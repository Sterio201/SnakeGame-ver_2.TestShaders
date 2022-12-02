using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShiftScriptCollision : MonoBehaviour
{
    [SerializeField] ClassSnake snake;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colorShift" || other.gameObject.tag == "Flags")
        {
            if(other.gameObject.tag == "colorShift")
            {
                snake.colorTexture = other.gameObject.GetComponent<MeshRenderer>().material.mainTexture;
            }
            else
            {
                snake.colorTexture = other.gameObject.GetComponent<MeshRenderer>().materials[2].mainTexture;
            }
            
            snake.meshRenderer.material.mainTexture = snake.colorTexture;

            if (snake.body.Count > 1)
            {
                for (int i = 1; i < snake.body.Count; i++)
                {
                    snake.body[i].GetComponent<MeshRenderer>().material.mainTexture = snake.colorTexture;
                }
            }
        }
    }
}