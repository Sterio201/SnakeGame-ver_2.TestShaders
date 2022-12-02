using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSnake : MonoBehaviour
{
    public string nameSnake;
    public float speed;
    public float speedTurn;
    public Texture colorTexture;
    public Texture standartTexture;
    public MeshRenderer meshRenderer;

    public GameObject bodyPart;
    public GameObject tailPrefab;

    [HideInInspector]
    public List<GameObject> body;
    [HideInInspector]
    public GameObject currentTail;

    [HideInInspector]
    public int currentScore;
    [HideInInspector]
    public int lvlTransition;

    private void Start()
    {
        currentScore = 0;
    }
}