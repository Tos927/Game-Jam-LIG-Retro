using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    
    public float bulletDamage = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        normalAI normal = hitInfo.GetComponent<normalAI>();
        if(normal != null){
            normal.TakingDamage(bulletDamage);
        }
        fastAI fast = hitInfo.GetComponent<fastAI>();
        if(fast != null){
            fast.TakingDamage(bulletDamage);
        }
        tankAI tank = hitInfo.GetComponent<tankAI>();
        if(tank != null){
            tank.TakingDamage(bulletDamage);
        }
        
        
        Destroy(gameObject);
    }
}
