using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] bool canSpawn = true;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(1.8f, 4.7f));

        while (canSpawn)
        {
            yield return wait;

            Instantiate(enemyPrefabs, transform.position, Quaternion.identity);
        }

    }
}
