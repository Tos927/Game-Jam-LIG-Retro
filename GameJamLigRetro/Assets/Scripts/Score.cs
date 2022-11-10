using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static Score instance;
    int score = 0;
    
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoint(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }
}
