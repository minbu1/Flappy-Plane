using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    int best = 0, second = 0;

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

        if (PlayerPrefs.HasKey("best"))
        {
            best = PlayerPrefs.GetInt("best");

            if (score > best)
            {
                best = score;
                PlayerPrefs.SetInt("best", best);
            }
            bestScoreText.text = best.ToString();
        }
        else
        {
            bestScoreText.text = score.ToString();
            PlayerPrefs.SetInt("best", score);
        }

        if (PlayerPrefs.HasKey("second"))
        {
            second = PlayerPrefs.GetInt("second");

            if (score > second && score < best)
            {
                second = score;
                PlayerPrefs.SetInt("second", second);
            }
        }
        else
        {
            second = score;
        }
        PlayerPrefs.Save();

        if (score >= best)
        {
            medalImage.sprite = medals[1];
        }
        else if (score >= second)
        {
            medalImage.sprite = medals[0];
        }
        else
        {
            medalImage.sprite = medals[0];
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
