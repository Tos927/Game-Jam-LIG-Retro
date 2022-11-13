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
    public float spawnTimer;
    public float spawnTimerDiminution;
    public float waveTimer;

    public int numberOfWaves = 15;
    private int waveNumber = 1;
    [SerializeField] private int waveAfterSpawnTimerNull = 0;
    
    private float amountOfNormal = 3f;
    public float normalMultiplier;

    private float amountOfFast = 1f;
    public float fastMultiplier;


    private float amountOfTank = 1f;
    public float tankMultiplier;


    public List<GameObject> attackBoostSpawns;
    public List<GameObject> attackSpeedBoostSpawns;
    public List<GameObject> SpeedBoostSpawns;
    public GameObject AttackBoost;
    public GameObject AttackSpeedBoost;
    public GameObject SpeedBoost;


    private bool secure = true;

    private bool test = false;
      
    
    void Update()
    {
        
        if(secure)
        {
           
            StartCoroutine(GameLoop());
                
            
            secure = false;
        }
        
    }
    

    private IEnumerator GameLoop()
    {
        for(int k = 0 ; k < numberOfWaves; k++)
        {
            //spawn des powerUp

            Destroy(GameObject.FindGameObjectWithTag("AttackBoost"));
            Destroy(GameObject.FindGameObjectWithTag("AttackSpeedBoost"));
            Destroy(GameObject.FindGameObjectWithTag("SpeedBoost"));
            int random = Random.Range(0,6);
            Instantiate(AttackBoost,attackBoostSpawns[random].transform);
            int random1 = Random.Range(0,6);
            Instantiate(AttackSpeedBoost,attackSpeedBoostSpawns[random1].transform);
            int random2 = Random.Range(0,6);
            Instantiate(SpeedBoost,SpeedBoostSpawns[random2].transform);
            



            //Spawn des IA
            if(waveAfterSpawnTimerNull <2)
            {
               
                for(int i = 0 ; i < spawnPoints.Count ; i++)
                {
                    if(waveNumber > 4)
                    {
                        for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                        {
                            Instantiate(iaTank, spawnPoints[i].transform);
                            yield return new WaitForSeconds(instantiateTimer);
                        }
                    }
                    for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
                    {
                        Instantiate(ia, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                    if(waveNumber >2){
                       for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
                        {
                            Instantiate(iaFast, spawnPoints[i].transform);
                            yield return new WaitForSeconds(instantiateTimer);
                        } 
                    }
                    
                    yield return new WaitForSeconds(spawnTimer);
                }
            }

            

            if(waveAfterSpawnTimerNull == 2)
            {
                
                for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                {
                    for(int iTank = 0 ; iTank < 2 ; iTank++)
                    {
                        Instantiate(iaTank, spawnPoints[iTank].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }                
                for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
                {
                    for(int iNormal = 0 ; iNormal < 2 ; iNormal++)
                    {
                        Instantiate(ia, spawnPoints[iNormal].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }
                for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
                {
                    for(int iFast = 0 ; iFast < 2 ; iFast++)
                    {
                        Instantiate(iaFast, spawnPoints[iFast].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }

                for(int i = 2 ; i < spawnPoints.Count ; i++)
                {
                    
                    for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                    {
                        Instantiate(iaTank, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                    for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
                    {
                        Instantiate(ia, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                    for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
                    {
                        Instantiate(iaFast, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                }


            }
                        
            if(waveAfterSpawnTimerNull == 3)
            {  
                for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                {
                    for(int iTank = 0 ; iTank < 3 ; iTank++)
                    {
                        Instantiate(iaTank, spawnPoints[iTank].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }
                for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
                {
                    for(int iNormal = 0 ; iNormal < 3 ; iNormal++)
                    {
                        Instantiate(ia, spawnPoints[iNormal].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }
                for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
                {
                    for(int iFast = 0 ; iFast < 3 ; iFast++)
                    {
                        Instantiate(iaFast, spawnPoints[iFast].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }


                for(int i = 3 ; i < spawnPoints.Count ; i++)
                {
                    for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                    {
                        Instantiate(iaTank, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                    for(int jNormal = 0 ; jNormal < amountOfNormal ; jNormal++)
                    {
                        Instantiate(ia, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                    for(int jFast = 0 ; jFast < amountOfFast ; jFast++)
                    {
                        Instantiate(iaFast, spawnPoints[i].transform);
                        yield return new WaitForSeconds(instantiateTimer);
                    }
                }


            }

            if(waveAfterSpawnTimerNull ==4)
            {
                
                
                for(int jTank = 0 ; jTank < amountOfTank ; jTank++)
                {
                    for(int iTank = 0 ; iTank < spawnPoints.Count ; iTank++)
                    {
                        Instantiate(iaTank, spawnPoints[iTank].transform);
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
                        Instantiate(iaFast, spawnPoints[iFast].transform);
                    }
                    yield return new WaitForSeconds(instantiateTimer);
                }
            
            
            }
            
            waveNumber ++;
            if(spawnTimer >0.5){
                spawnTimer *= spawnTimerDiminution;
            }else if(spawnTimer <= 0.5){
                spawnTimer= 0;
            } 
            if(spawnTimer == 0){
                waveAfterSpawnTimerNull ++;
            }
            amountOfNormal *= normalMultiplier;
            if(waveNumber > 3)
            {
                amountOfFast *= fastMultiplier;
            }
            if(waveNumber > 5){
                amountOfTank *= tankMultiplier;
            }
            yield return new WaitForSeconds(waveTimer);
        }
            
        
    }
}
