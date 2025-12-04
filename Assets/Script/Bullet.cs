using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.2f, 0);
        if (transform.position.y > 7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity); 
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
