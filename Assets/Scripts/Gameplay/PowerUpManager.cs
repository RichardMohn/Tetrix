using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject[] powerUps;
    private float spawnInterval = 10f;

    void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }

    IEnumerator SpawnPowerUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            int randomIndex = Random.Range(0, powerUps.Length);
            Instantiate(powerUps[randomIndex], new Vector3(Random.Range(0, 10), 20, 0), Quaternion.identity);
        }
    }
}