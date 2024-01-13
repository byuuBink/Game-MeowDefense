using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SkeletonMovement : MonoBehaviour
{   
    public float moveSpeed = 3f;

    PointManager pointManag;

    private void Awake()
    {
        pointManag = FindObjectOfType<PointManager>();
    }


    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collider"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            moveSpeed = 1f;
        }
    }


}
