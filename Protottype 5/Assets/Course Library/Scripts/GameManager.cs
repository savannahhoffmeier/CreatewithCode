﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        isGameActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

}
