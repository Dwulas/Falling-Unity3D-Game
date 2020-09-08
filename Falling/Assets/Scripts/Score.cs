using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform score;
    public Text scoreText;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetString("HightScore");
    }

    private void Update()
    {
        scoreText.text = score.position.y.ToString("0");
    }

    private void OnCollisionEnter(Collision collision)
    {

        PlayerPrefs.SetString("HightScore", scoreText.text);

        if (int.Parse(scoreText.text) > int.Parse(PlayerPrefs.GetString("HightScore")))
        {
            PlayerPrefs.GetString("HightScore");
            highScore.text= scoreText.text;
        }
    }

}