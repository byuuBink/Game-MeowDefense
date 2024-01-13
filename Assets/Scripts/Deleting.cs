using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleting : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(8);
        Object.Destroy(gameObject);
    }
}
