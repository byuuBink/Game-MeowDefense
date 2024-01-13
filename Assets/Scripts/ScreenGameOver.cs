using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScreenGameOver : MonoBehaviour
{
    public GameObject GameOverScreen;

    PlayerLives playerLivesScript;


    private void Awake()
    {
        playerLivesScript = FindObjectOfType<PlayerLives>();
    }

    private void Update()
    {
        if (playerLivesScript.isDead == true)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);
    }
}
