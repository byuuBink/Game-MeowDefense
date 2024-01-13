using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float verticalInput;

    [SerializeField] private AudioSource healSoundEffect;

    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * verticalInput * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Heart"))
        {
            healSoundEffect.Play();
        }
    }
}
