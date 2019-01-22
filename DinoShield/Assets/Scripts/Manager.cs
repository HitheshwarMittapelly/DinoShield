﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager Instance = null;
    public Image lifeOne;
    public Image lifeTwo;
    public Image lifeThree;
    public Text scoreText;
    private int score = 0;
    private int damagedEggs = 0;
    public void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

       
    }
    // Use this for initialization
    void Start () {
        scoreText.text = "";
        //scoreText.text = "Score :"+ score.ToString() ;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score : " + score.ToString();
    }

    public void updateScore()
    {
        score++;

    }
    public void updateDamagedEggs()
    {
       
        damagedEggs++;
        if(damagedEggs == 1)
        {
            lifeThree.CrossFadeAlpha(0f, 0.1f, false);
        }else if(damagedEggs == 2)
        {
            lifeTwo.CrossFadeAlpha(0f, 0.1f, false);
        }
        else if(damagedEggs == 3)
        {
            lifeOne.CrossFadeAlpha(0f, 0.1f, false);
        }
        else if(damagedEggs>3)
        {
            Debug.Log("Game Over");
        }
    }
}
