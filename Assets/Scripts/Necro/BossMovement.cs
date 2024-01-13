using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossMovement : MonoBehaviour
{

    public float bossSpeed = 4f;
    PlayerLives pplayerLives;

    [SerializeField] private AudioSource meowSoundEffect;

    private void Awake()
    {
        pplayerLives = FindObjectOfType<PlayerLives>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * bossSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collider")
        {
            Destroy(gameObject);
            pplayerLives.NumberOfHearts -= 3;
            for (int i = 0; i < pplayerLives.Hearts.Length; i++)
            {
                if (i < pplayerLives.NumberOfHearts)
                {
                    pplayerLives.Hearts[i].enabled = true;
                }
                else
                {
                    pplayerLives.Hearts[i].enabled = false;
                }
            }
        }
    }
}
