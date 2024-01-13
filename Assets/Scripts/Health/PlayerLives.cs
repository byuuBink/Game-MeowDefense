using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int NumberOfHearts = 3;
    public int MaxHearts = 3;
    public Image[] Hearts;
    public bool isDead = false;



    private void Update()
    {
        if (NumberOfHearts <= 0)
        {
            isDead = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            NumberOfHearts -= 1;
            for(int i = 0; i < Hearts.Length; i++)
            {
                if(i < NumberOfHearts)
                {
                    Hearts[i].enabled = true;
                }
                else
                {
                    Hearts[i].enabled = false;
                }
            }
        }

    }

}
