using UnityEngine;
using System.Collections;

public class Elf : EnemyParent
{
    private Renderer rend;
    private bool isVisible = true;

    void Start()
    {
        // Stel stats in via de parent-class functies
        SetMaxHealth(2);
        MoveSpeed = 6f;

        rend = GetComponentInChildren<Renderer>();

        // Start de coroutine die de zichtbaarheid om de paar seconden verandert
        StartCoroutine(ToggleVisibility());

        Debug.Log($"Elf spawned with {Health} HP and fast speed {MoveSpeed}");
    }

    private IEnumerator ToggleVisibility()
    {
        while (true)
        {
            // Wacht 3 seconden, maak onzichtbaar
            yield return new WaitForSeconds(3f);
            isVisible = !isVisible;

            if (rend != null)
                rend.enabled = isVisible;

            // Blijf 0.5 seconden onzichtbaar, daarna weer zichtbaar
            yield return new WaitForSeconds(0.5f);

            if (rend != null)
                rend.enabled = true;
        }
    }
}
