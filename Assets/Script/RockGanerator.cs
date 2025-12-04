using UnityEngine;
using System.Collections;
public class RockGanerator : MonoBehaviour
{
    public GameObject rockPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenRock", 2.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenRock()
    {
        float x = Random.Range(-2.5f, 2.5f);
        Instantiate(rockPrefab, new Vector3(x, 5, 0), Quaternion.identity);
    }
}
