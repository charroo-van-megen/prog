using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;

    public event Action<int> onScoreChanged;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        onScoreChanged?.Invoke(score);  
    }
}
