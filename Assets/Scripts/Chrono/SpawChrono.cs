using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawChrono : MonoBehaviour
{

    public GameObject chronoMagePrefab;
    [SerializeField] private AudioSource shootSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(chronoMagePrefab, transform.position, Quaternion.identity);
            shootSoundEffect.Play();
        }
    }
}
