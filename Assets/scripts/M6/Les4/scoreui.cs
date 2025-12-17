using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        ScoreManager.Instance.onScoreChanged += UpdateScore;
    }

    private void OnDestroy()
    {
        ScoreManager.Instance.onScoreChanged -= UpdateScore;
    }

    void UpdateScore(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
