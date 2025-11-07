using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 10f;
    public bool useInput = false; // alleen het schip gebruikt input

    void Update()
    {
        float input = useInput ? Input.GetAxis("Vertical") : 1f;
        transform.position += transform.forward * moveSpeed * input * Time.deltaTime;
    }
}
