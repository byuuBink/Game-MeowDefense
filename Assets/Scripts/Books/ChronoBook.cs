using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBook : MonoBehaviour
{
    [SerializeField] GameObject bookPrefab;
    [SerializeField] bool canSpaw = true;

    private void Start()
    {
        StartCoroutine(SpawChronoBook());
    }

    IEnumerator SpawChronoBook()
    {
        WaitForSeconds wait = new WaitForSeconds(Random.Range(40f, 65f));
        while (canSpaw)
        {
            yield return wait;
            Instantiate(bookPrefab, transform.position, Quaternion.identity);
        }
    }
}
