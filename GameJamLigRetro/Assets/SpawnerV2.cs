using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerV2 : MonoBehaviour
{
    public List<GameObject> spawnPoints;
    public GameObject ia;
    public GameObject iaFast;
    public GameObject iaTank;

    public float instantiateTimer;
    public float waveTimer;

    private int waveNumber = 1;


    private float amountOfNormal = 3f;
    public float normalMultiplier;

    private float amountOfFast = 1f;
    public float fastMultiplier;


    private float amountofTank = 1f;
    public float tankMultiplier;

    private bool secure = true;
      
    
    
    void Update()
    {
        
        if(secure)
        {
           
            StartCoroutine(SpawnIa());
                
            
            secure = false;
        }
        
    }

    private IEnumerator SpawnIa()
    {







        yield return new WaitForSeconds(1);
    }

}
