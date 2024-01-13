using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject PausePanel;

    void Update()
    {
        if (Input.GetButtonDown("Cancel")){
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        isPaused = false;
    }
}
