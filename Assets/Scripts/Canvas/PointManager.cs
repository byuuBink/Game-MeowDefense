using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int point)
    {
        score += point;
        scoreText.text = "Score" + score;
    }
}
