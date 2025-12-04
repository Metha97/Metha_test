using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.fallSpeed = 0.0002f + 0.001f * Random.value;
        this.rotSpeed = 0.5f + 0.3f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
