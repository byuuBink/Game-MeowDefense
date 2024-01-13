using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMageBook : MonoBehaviour
{
    [SerializeField] GameObject bookPrefab;
    [SerializeField] bool canSpawn = true;


    void Start()
    {
        StartCoroutine(SpawIceMageBook());
    }

    IEnumerator SpawIceMageBook()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(25f, 40f));

        while (canSpawn)
        {
            yield return wait;

            Instantiate(bookPrefab, transform.position, Quaternion.identity);
        }
    }
}
