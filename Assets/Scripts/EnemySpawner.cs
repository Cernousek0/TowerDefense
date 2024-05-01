using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject destinationObject;
    [SerializeField]
    private GameObject enemyObject;
    private float spawn_delay = 5.0f;
    float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = spawn_delay;
    }

    // Update is called once per frame
    void Update()
    {
        
       timeLeft -= Time.deltaTime;
         if(timeLeft <= 0)
         {
              timeLeft = spawn_delay;
              SpawnEnemy();
         } 
    }


    void SpawnEnemy()
    {
      GameObject enemy = Instantiate(enemyObject, transform.position, Quaternion.identity);
      Component EnemyScript =  enemy.AddComponent<Enemy>();
      EnemyScript.GetType().GetField("target").SetValue("target", destinationObject);
      Debug.Log("Enemy spawned");
      Debug.Log(EnemyScript.GetType().GetField("target"));
    }
}
