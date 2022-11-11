using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHP : MonoBehaviour
{
    
    public float health;
    public float minDamage;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(health);
    }
    
    
    public void TakingDamage(float damage)
    {
        health -= damage + minDamage;
        healthBar.SetHealth(health);


        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public bool isDead(){
        if(health<=0){
            return true;
        }else{
            return false;
        }
    }
}
