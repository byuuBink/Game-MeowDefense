using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{
    PlayerLives playerlives;

    private void Awake()
    {
        playerlives = FindObjectOfType<PlayerLives>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            playerlives.NumberOfHearts += 1;
            for (int i = 0; i < playerlives.Hearts.Length; i++)
            {
                if (i < playerlives.NumberOfHearts)
                {
                    playerlives.Hearts[i].enabled = true;
                }
                else
                {
                    playerlives.Hearts[i].enabled = false;
                }
            }
            if (playerlives.NumberOfHearts > playerlives.MaxHearts)
            {
                playerlives.NumberOfHearts = 3;
            }
        }
    }

}

