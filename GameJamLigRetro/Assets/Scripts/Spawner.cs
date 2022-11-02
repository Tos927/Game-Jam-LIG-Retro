using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public List<GameObject> spawnPoints;
    public GameObject ia;

    public float timer;
    
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
        
        for(int i = 0 ; i<4; i++){
            for(int y = 0 ; y < spawnPoints.Count ; y++)
        {
            Instantiate(ia, spawnPoints[y].transform);
            

        }
            yield return new WaitForSeconds(timer);
        }
        
    }
}
