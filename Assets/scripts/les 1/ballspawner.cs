using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color c = RandomColor();
            Vector3 pos = RandomPosition(-10f, 10f);
            CreateBall(c, pos);
        }
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color c = RandomColor();
            Vector3 pos = RandomPosition(-10f, 10f);
            GameObject ball = CreateBall(c, pos);
            DestroyBall(ball);
            elapsedTime = 0f;
        }
    }

    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        MeshRenderer mr = ball.GetComponent<MeshRenderer>();
        if (mr != null)
        {
            Material mat = mr.material; // let op: dit maakt een instance van het materiaal
            if (mat.shader.name == "Universal Render Pipeline/Lit")
                mat.SetColor("_BaseColor", c);
            else
                mat.SetColor("_Color", c);
        }
        return ball;
    }

    private void DestroyBall(GameObject g)
    {
        Destroy(g, 3f);
    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(5f, 12f); // boven de grond zodat hij kan vallen
        float z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
}
