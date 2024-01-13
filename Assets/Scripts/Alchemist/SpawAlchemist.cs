using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawAlchemist : MonoBehaviour
{
    public GameObject alchemistPrefab;
    [SerializeField] private AudioSource shootSoundEffect;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(alchemistPrefab, transform.position, Quaternion.identity);
            shootSoundEffect.Play();
        }
    }
}
