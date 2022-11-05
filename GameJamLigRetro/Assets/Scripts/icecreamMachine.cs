using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icecreamMachine : MonoBehaviour
{
    
    
    public float baseHealth;
    public LayerMask normalAI;
    public LayerMask fastAI;
    public LayerMask tankAI;


    private Collider2D col;

    void Start()
    {
      col = GetComponent<CircleCollider2D>();  
    }

    
    void Update()
    {
        if(col.IsTouchingLayers(normalAI))
        {
            baseHealth -= 20f;
        }

        if(col.IsTouchingLayers(fastAI))
        {
            baseHealth -= 10f;
        }

        if(col.IsTouchingLayers(tankAI))
        {
            baseHealth -= 40f;
        }


        if(baseHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
