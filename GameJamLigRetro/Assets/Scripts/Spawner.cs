using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public List<GameObject> spawnPoints;
    public GameObject ia;

    public float spawnTimer;
    public float waveTimer;

    private int amountOfEnemy = 4;

    
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
        for(int k = 0 ; k < 4; k++)
        {
            for(int j = 0 ; j < amountOfEnemy ; j++)
            {
                for(int i = 0 ; i < spawnPoints.Count ; i++)
                {
                    Instantiate(ia, spawnPoints[i].transform);
                

                }
                yield return new WaitForSeconds(spawnTimer);
            }
            amountOfEnemy ++;
            yield return new WaitForSeconds(waveTimer);
        }
            
        
    }
}
