using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointEnemys : MonoBehaviour
{

    public GameObject [] enemy1Prefab;
    
    [Space]
    public int numEnemysForWave; 
    public float  frecEnemyforWave;
    [Space]
    
    public int numWaves;
    public float frecIntoWave; 

    int waveCount=0; 
    int wavesCount=0; 

    bool waveInProgress ; 
    void Start(){
        
        CreateWaves();
        
    }

    void FixedUpdate(){
        if(!waveInProgress){
          if(waveCount<numWaves){
           waveInProgress=true; 

Invoke("CreateWaves", frecIntoWave); 
}

        }else {
            wavesCount=0; 
        }
    }
    
   void SpawnEnemy()
   {
       int i = Random.Range(0,2);
          GameObject enemyTemp= Instantiate(enemy1Prefab[i],transform.position,Quaternion.identity);   
            
    
   }

   void CallCreateWave(){
       CreateWave(numEnemysForWave,frecEnemyforWave);
   }



   void CreateWave(int numEnemy, float frequencia){
       SpawnEnemy();

       waveCount++; 
       if (waveCount< numEnemy)
       {
           waveInProgress=true; 
       Invoke("CallCreateWave", frequencia);    
       }else{
           CancelInvoke("CallCreateWave");
           waveCount=0; 
           waveInProgress=false; 
       }
        
   }
void CreateWaves(){
        CreateWave(numEnemysForWave,frecEnemyforWave);
        wavesCount++;

}
 
}
