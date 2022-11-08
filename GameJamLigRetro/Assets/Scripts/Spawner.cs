using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
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
        for(int k = 0 ; k < 5; k++)
        {
            for(int jTank = 0 ; jTank < amountofTank ; jTank++)
            {
                for(int iTank = 0 ; iTank < spawnPoints.Count ; iTank++)
                {
                    if(waveNumber > 4){
                        Instantiate(iaTank, spawnPoints[iTank].transform);
                    }
                    
                

                }
                yield return new WaitForSeconds(instantiateTimer);
            }
            
            
            
            for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
            {
                for(int iNormal = 0 ; iNormal < spawnPoints.Count ; iNormal++)
                {
                    Instantiate(ia, spawnPoints[iNormal].transform);
                

                }
                yield return new WaitForSeconds(instantiateTimer);
            }
            
            
            for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
            {
                for(int iFast = 0 ; iFast < spawnPoints.Count ; iFast++)
                {
                    if(waveNumber > 2){
                        Instantiate(iaFast, spawnPoints[iFast].transform);
                    }
                                    
                }
                yield return new WaitForSeconds(instantiateTimer);
            }
            
            waveNumber ++;
            amountOfNormal *= normalMultiplier;
            if(waveNumber > 3)
            {
                amountOfFast *= fastMultiplier;
            }
            if(waveNumber > 5){
                amountofTank *= tankMultiplier;
            }
            yield return new WaitForSeconds(waveTimer);
        }
            
        
    }
}
