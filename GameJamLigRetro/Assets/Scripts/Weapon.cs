using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float BulletSpeed = 3f;
    public float Cadence = 1f;

    void Update()
    {
        BulletSpeed -= Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (Mathf.Round(BulletSpeed) <= 0)
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

