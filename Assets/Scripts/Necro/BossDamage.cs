using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{
    PlayerLives playerlives2;

    private void Awake()
    {
        playerlives2 = FindObjectOfType<PlayerLives>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerlives2.NumberOfHearts -= 3;
            for (int i = 0; i < playerlives2.Hearts.Length; i++)
            {
                if (i < playerlives2.NumberOfHearts)
                {
                    playerlives2.Hearts[i].enabled = true;
                }
                else
                {
                    playerlives2.Hearts[i].enabled = false;
                }
            }
        }

    }
}
