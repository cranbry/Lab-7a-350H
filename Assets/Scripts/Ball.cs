using UnityEngine;

public class Ball : MonoBehaviour
{
    public float minMag = 3f;
    public float maxMag = 5f;
    private int collisionsCount = 0;
    private int collisionsMax = 20;
    public GameObject explosion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        Vector3 position = transform.position;
        position.x = 4;
        transform.position = position;
        Debug.Log("the first game object");
        transform.localScale *= 2;

        // rb2d.AddForce(new Vector2(1, 1), ForceMode2D.Impulse);

        float magnitude = Random.Range(minMag, maxMag);
        float randomAngle = Random.Range(0f, Mathf.PI * 2f);

        Vector2 randomDirection = new Vector2(
            Mathf.Cos(randomAngle),
            Mathf.Sin(randomAngle)
        );

        rb2d.AddForce(randomDirection * magnitude, ForceMode2D.Impulse);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collisionsCount++;
        Debug.Log("Bang");
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionsCount >= collisionsMax)
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
