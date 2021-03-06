﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool gameOver = false;
    public float score = 0;
    public static GameController instance;
    // Use this for initialization
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update ()
    {
        if (score > PlayerPrefs.GetFloat("HighScore"))
            PlayerPrefs.SetFloat("HighScore", score);
        if (gameOver)
        {       
            SceneManager.LoadScene("MainMenu");
        }
	}
}
