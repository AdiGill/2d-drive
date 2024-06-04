using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class gameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public PlayerPrefs player;

    public void IncreaseScoreOverTime(){
        score++;
    }
    public void IncreaseScore(){
        score+= 15;
    }
    public void GameOver(){
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    private void Awake(){
        Pause();
        Application.targetFrameRate = 60;
    }
    public void Play(){
        score = 0;
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale=1f;
        Cars[] cars = FindObjectsOfType<Cars>();
        for(int i = 0; i<cars.Length; i++){
            Destroy(cars[i].gameObject);
        }
    }
    public void Pause(){
        Time.timeScale = 0f;
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
