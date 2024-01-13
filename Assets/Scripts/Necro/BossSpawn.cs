using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BossSpawn : MonoBehaviour
{
    [SerializeField] private GameObject BossPrefab;
    PointManager pointManager;

    public int scoreToSpawn = 50;
    public int bossSpawned;


    private void Awake()
    {
        pointManager = FindObjectOfType<PointManager>();
    }

    public void SpawnBoss()
    {
        Instantiate(BossPrefab, transform.position, Quaternion.identity);
    }


    void Update()
    {
        if (pointManager.score == scoreToSpawn)
        {
            SpawnBoss();
            bossSpawned +=1;
        }
        if (bossSpawned == 1)
        {
            Destroy(this.gameObject);
        }
    }

}
