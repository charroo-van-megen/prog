using UnityEngine;

[RequireComponent(typeof(Movement))]
public class ShipMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontal * rotationSpeed * Time.deltaTime);
    }
}
