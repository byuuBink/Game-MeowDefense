using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    private PointManager pointManager;
    private BossSpawn bossSpawnScript;


    void Start()
    {
        rb.velocity = transform.right * speed;
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            pointManager.UpdateScore(1);
        }

        if (collision.gameObject.tag == "Boss")
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
