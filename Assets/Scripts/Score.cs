using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI ScoreBox;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Pipe"))
        {
            score += 1;
        }
    }
    private void Update()
    {
        ScoreBox.text = string.Format($"Score: {score}");
    }
}
