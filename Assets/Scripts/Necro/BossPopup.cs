using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPopup : MonoBehaviour
{
    public GameObject popupActive;

    PointManager pointManagerScore;

    private void Awake()
    {
        pointManagerScore = FindObjectOfType<PointManager>();
    }

    private void Update()
    {
        if (pointManagerScore.score >=46)
        {
            isShowing();
        }
        if (pointManagerScore.score >= 50)
        {
            notShowing();
        }
        if (pointManagerScore.score >= 96)
        {
            isShowing();
        }
        if (pointManagerScore.score >= 100)
        {
            notShowing();
        }
    }
    public void isShowing()
    {
        popupActive.SetActive(true);
    }

    public void notShowing()
    {
        popupActive.SetActive(false);
    }
}
