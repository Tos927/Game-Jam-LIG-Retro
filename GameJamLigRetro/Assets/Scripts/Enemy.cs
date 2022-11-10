using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health<=0)
        {
            Destroy(gameObject);
            Score.instance.AddPoint(250);
        }
    }
}
