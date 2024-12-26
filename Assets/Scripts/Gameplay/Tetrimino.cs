using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrimino : MonoBehaviour
{
    public Color blockColor;

    void Start()
    {
        GetComponent<Renderer>().material.color = blockColor;
    }
}