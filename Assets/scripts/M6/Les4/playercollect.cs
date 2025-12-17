using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(other.gameObject);
        }
    }
}
