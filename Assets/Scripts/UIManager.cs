using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [Header("Score Board")]
    public GameObject scoreBoard;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image medalImage;

    public Sprite[] medals;

    public void DisplayScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void DisplayScoreBoard(int score)
    {
        scoreBoard.SetActive(true);
        finalScoreText.text = score.ToString();

        scoreText.gameObject.SetActive(false);

        bestScoreText.text = "9999";
        medalImage.sprite = medals[Random.Range(0, medals.Length)];
    }
}
