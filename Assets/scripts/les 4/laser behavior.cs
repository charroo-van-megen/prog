using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
