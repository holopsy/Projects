using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 loodDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(loodDirection * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}