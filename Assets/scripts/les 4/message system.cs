using UnityEngine;
using TMPro;
using System.Collections;

public class MessageSystem : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text messageField;
    public float defaultDisplayTime = 3f;

    void Start()
    {
        // Introductie gebruiken via dezelfde functie
        StartCoroutine(ShowMessage("Welcome to Space 4 8!\nMove with arrows or WASD.\nShoot with SPACE.\nCollect pickups and use with E.", 5f));
    }

    public IEnumerator ShowMessage(string message, float duration = -1f)
    {
        if (messageField == null)
        {
            Debug.LogWarning("No messageField assigned!");
            yield break;
        }

        messageField.enabled = true;
        messageField.text = message;

        float showTime = duration > 0 ? duration : defaultDisplayTime;
        yield return new WaitForSeconds(showTime);

        messageField.enabled = false;
    }
}
