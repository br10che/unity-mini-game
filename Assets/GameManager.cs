using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int totalCoins;
    public TextMeshProUGUI scoreText;
    public GameObject winText;

    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        scoreText.text = "Score: 0";
        winText.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= totalCoins)
        {
            winText.SetActive(true);
        }
    }
}