using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public int score = 0;
    public int life = 3;
    public GameObject scoreText;
    public GameObject LifeText;
    public GameObject OverText;
    public GameObject[] balls;

    private float spawnLimitLeft = -8;
    private float spawnLimitRight = 8;

    private float spawnPosY = 10;
    // Start is called before the first frame update
    void Start()
    {
        
        //StartCoroutine(randomInterval());
        Invoke("StartRandomInterval", 3f);
        OverText.GetComponent<TextMeshProUGUI>().enabled = false;
    }
    
    void StartRandomInterval()
    {
        StartCoroutine(randomInterval());
    }

    void LateUpdate()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();
        LifeText.GetComponent<TextMeshProUGUI>().text = "Life: " + life.ToString();
        if (life <= 0)
        {
            OverText.GetComponent<TextMeshProUGUI>().enabled = true;
            Time.timeScale = 0;
        }
    }

    void SpawnBall()
    {
        int index = Random.Range(0, balls.Length);
        Vector3 spawnPos= new Vector3(Random.Range(spawnLimitLeft, spawnLimitRight), spawnPosY, 0);
        Instantiate(balls[index], spawnPos, balls[index].transform.rotation);
    }

    IEnumerator randomInterval()
    {
        float minInterval = 0f;
        float maxInterval = 3;

        while (true)
        {
            float interval = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(interval);

            SpawnBall();
        }
    }
}
