using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiremageBook : MonoBehaviour
{
    [SerializeField] GameObject bookPrefab;
    [SerializeField] bool canSpawn = true;


    void Start()
    {
        StartCoroutine(SpawFireMageBook());
    }

    IEnumerator SpawFireMageBook()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(20f, 40f));

        while (canSpawn)
        {
            yield return wait;

            Instantiate(bookPrefab, transform.position, Quaternion.identity);
        }
    }
}
