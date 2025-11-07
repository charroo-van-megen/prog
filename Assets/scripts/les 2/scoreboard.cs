using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        // Abonneren op het Action Event van Pickup
        Pickup.OnPickupCollected += AddScore;
    }

    void OnDestroy()
    {
        // Altijd netjes afmelden om memory leaks te voorkomen
        Pickup.OnPickupCollected -= AddScore;
    }

    private void AddScore()
    {
        score += 50; // Elke pickup = 50 punten
        scoreText.text = "Score: " + score;
    }
}
