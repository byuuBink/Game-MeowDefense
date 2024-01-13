using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawIceMage : MonoBehaviour
{
    public GameObject iceMagePrefab;
    [SerializeField] private AudioSource shootSoundEffect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(iceMagePrefab, transform.position, Quaternion.identity);
            shootSoundEffect.Play();
        }
    }
}
