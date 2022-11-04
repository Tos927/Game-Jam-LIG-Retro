using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReaction : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Coin" || gameObject.tag == "SpeedBoost" || gameObject.tag == "AttackSpeedBoost" || gameObject.tag == "AttackBoost")
        {
            if (collision.tag == "Player")
            {
                Destroy(gameObject);
            }
        }

    }



}
