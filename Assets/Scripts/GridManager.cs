using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 10;
    public int height = 20;
    private Transform[,] grid;

    void Start()
    {
        grid = new Transform[width, height];
    }

    public void AddToGrid(Transform block)
    {
        Vector3 position = block.position;
        grid[Mathf.RoundToInt(position.x), Mathf.RoundToInt(position.y)] = block;
    }

    public bool IsRowFull(int y)
    {
        for (int x = 0; x < width; x++)
        {
            if (grid[x, y] == null) return false;
        }
        return true;
    }

    public void ClearRow(int y)
    {
        for (int x = 0; x < width; x++)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }
}