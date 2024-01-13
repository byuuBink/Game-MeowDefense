using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alchemistBook : MonoBehaviour
{
    [SerializeField] GameObject bookPrefab;
    [SerializeField] bool canSpawn = true;


    void Start()
    {
        StartCoroutine(SpawAlchemistBook());
    }

    IEnumerator SpawAlchemistBook()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(35f, 60f));

        while (canSpawn)
        {
            yield return wait;

            Instantiate(bookPrefab, transform.position, Quaternion.identity);
        }
    }
}
