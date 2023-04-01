using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score = 0;

    private void Start()
    {
        UpdateScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}