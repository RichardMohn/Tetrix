using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GridManager gridManager;
    public GameObject blockPrefab;

    void Start()
    {
        SpawnNewBlock();
    }

    void SpawnNewBlock()
    {
        GameObject newBlock = Instantiate(blockPrefab, new Vector3(5, 18, 0), Quaternion.identity);
        gridManager.AddToGrid(newBlock.transform);
    }
}