using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    public static StatsManager Instance;

    [Header("Stats")]
    public int health = 100;
    public int score = 0;

    [Header("UI")]
    public Text healthText;
    public Text scoreText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, 100);
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;

        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
