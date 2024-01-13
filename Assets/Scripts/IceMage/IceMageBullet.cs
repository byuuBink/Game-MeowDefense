using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMageBullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Collider")
        {
            Destroy(gameObject);
        }
    }
}
