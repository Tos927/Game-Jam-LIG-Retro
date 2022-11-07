using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float Damage = 2f;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(Damage);
        }
        
        Destroy(gameObject);
    }
}
