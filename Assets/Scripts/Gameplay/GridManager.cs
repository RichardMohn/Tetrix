using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject[] tetrominoes;
    private GameObject currentTetromino;

    void Start()
    {
        SpawnTetromino();
    }

    void SpawnTetromino()
    {
        int randomIndex = Random.Range(0, tetrominoes.Length);
        currentTetromino = Instantiate(tetrominoes[randomIndex], transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (currentTetromino == null)
        {
            SpawnTetromino();
        }
    }
}