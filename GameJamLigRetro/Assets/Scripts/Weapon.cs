using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float Cadence;
    private bool canShoot;
    private bool isShooting;

    void Start()
    {
        canShoot =true;
        isShooting =false;
    }
    
    
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            
            if (canShoot && !isShooting)
            {
                StartCoroutine(Shoot());
                
            }
        }
    }

    private IEnumerator Shoot()
    {
        
        canShoot = false;
        isShooting = true;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(Cadence);
        isShooting = false;
        canShoot = true;
    
        
    }

    
}   

