using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        float s = Random.Range(0.5f, 2f);
        transform.localScale = new Vector3(s, s, s);
    }
}
