using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

   
    public void Player1Scored()
    {
        Player1Score++;
        if(Player1Score == 3)
        {
            Debug.Log("Player 1 WINS!");
            Player1Text.GetComponent<TextMeshProUGUI>().text = "WIN";
            Player2Text.GetComponent<TextMeshProUGUI>().text = "LOSE";
            EndGame();
        }
        else
        {
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
            ResetPosition();
        }
    }

    public void Player2Scored()
    {
        Player2Score++;
        if(Player2Score == 3)
        {
            Debug.Log("Player 2 WINS!");
            Player2Text.GetComponent<TextMeshProUGUI>().text = "WIN";
            Player1Text.GetComponent<TextMeshProUGUI>().text = "LOSE";
            EndGame();
        }
        else
        {
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
            ResetPosition();
        }
    }

    private void EndGame()
    {
        ball.GetComponent<Ball>().End();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
