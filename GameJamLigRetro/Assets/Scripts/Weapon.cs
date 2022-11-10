using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float BulletSpeed = 3f;
    public float Cadence;

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            BulletSpeed -= Time.deltaTime;
            if (Mathf.Round(BulletSpeed) == 0)
            {
                Shoot();
                BulletSpeed = Cadence;
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }

    
}   

