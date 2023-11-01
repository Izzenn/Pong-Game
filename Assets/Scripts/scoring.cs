using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoring : MonoBehaviour
{
    public int player1 = 0;
    public int player2 = 0;
    public TextMeshProUGUI playerscore;
    public TextMeshProUGUI oppscore;
    public GameObject Ball;
    public GameObject Player1Win;
    public GameObject Player2Win;
    public BallScript BallScript;
    public GameObject Player1;
    public GameObject Player2;

    void Start()
    {
        BallScript = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallScript>();
    }

    public void AddScorePlayer()
    {
        player1 = player1 + 1;
        playerscore.text = player1.ToString();
        if (player1 == 15)
        {
            Ball.SetActive(false); 
            Player1Win.SetActive(true);
            Player2.SetActive(false);
            Player1.SetActive(false);   
        }
    }
    public void AddScoreOpp()
    {
        player2 = player2 + 1;
        oppscore.text = player2.ToString();
        if (player2 == 15)
        {
            Ball.SetActive(false);
            Player2Win.SetActive(true);
            Player2.SetActive(false);
            Player1.SetActive(false);
        }
    }
    public void Rematch()
    {
        Ball.SetActive(true);
        Player2.SetActive(true);
        Player1.SetActive(true);
        Player1Win.SetActive(false);
        Player2Win.SetActive(false);
        player1 = 0;
        playerscore.text = player1.ToString();
        player2 = 0;
        oppscore.text = player2.ToString();
        Ball.transform.position = new Vector3(0f, 0f, 0f);
        BallScript.launchBall();
    }
}

