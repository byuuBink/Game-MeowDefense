using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawing : MonoBehaviour
{
    [SerializeField] GameObject heartPrefab;
    [SerializeField] bool canSpawn = true;


    void Start()
    {
        StartCoroutine(HeartSpawn());
    }

    IEnumerator HeartSpawn()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(20f, 30f));

        while (canSpawn)
        {
            yield return wait;

            Instantiate(heartPrefab, transform.position, Quaternion.identity);
        }
    }

}
