using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector3 target;

    public void Seek(Vector3 targetPosition)
    {
        target = targetPosition;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }
    }

    // Getter en Setter (voorbeeld van read & write met controle)
    public float Speed
    {
        get => speed;
        set => speed = Mathf.Abs(value); // altijd positief, voorkomt fouten
    }
}
