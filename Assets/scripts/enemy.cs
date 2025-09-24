using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // beweeg langs wereld z-as (naar +z)
        transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
    }
}
