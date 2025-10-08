using UnityEngine;
using TMPro;  // nodig voor TextMeshPro

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;

    void Start()
    {
        textField = GetComponent<TMP_Text>();

        // Abonneren op event
        Pickup.OnPickupCollected += AddScore;

        UpdateUI();
    }

    private void AddScore(int points)
    {
        score += points;
        UpdateUI();
    }

    private void UpdateUI()
    {
        textField.text = "Score: " + score;
    }

    private void OnDestroy()
    {
        // Heel belangrijk: uitschrijven van het event
        Pickup.OnPickupCollected -= AddScore;
    }
}
