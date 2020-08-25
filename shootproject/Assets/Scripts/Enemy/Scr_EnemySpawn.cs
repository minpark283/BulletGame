using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_EnemySpawn : MonoBehaviour
{
   
    public GameObject enemytoSpawn;
    public List<GameObject> SpawnList;
    public float XlocRelativetoCamera;
    public float YlocRelativetoCamera;

    public float numSpawn;
    public float locNum;
    public float timebetweenSpawn;
    public float delayBetweenLoc;
    // Use this for initialization
    void Start()
    {
        SpawnList = new List<GameObject>();
    }
    //Optional Vector2 enterLoc is there for locations in which unit enters the scene.
     public IEnumerator spawnFunct(Vector2 source, Vector2 offset, float SpawnNum
         ,Vector2 EnterLoc, float EnterTime)
    {
        Vector2 diff = source + offset;
        for (int i = 0; i < SpawnNum; i++)
        {
            Debug.Log("Spawn!");
            GameObject spawn = (GameObject) Instantiate(enemytoSpawn, diff, Quaternion.identity);
            SpawnList.Add(spawn);
            Scr_Enemy_info.BasicEnemy temp = new Scr_Enemy_info.BasicEnemy(spawn, spawn.GetComponent<Rigidbody2D>());
            // temp.moveTo(new Vector2(1, 2), 1.5f);
            StartCoroutine(temp.moveTo( EnterLoc, EnterTime));

            yield return new WaitForSeconds(timebetweenSpawn);
           

        }
    }

    //LocList is list that contains all the different locations to spawn from
    //EnterList optional list that contains Vector2 of enterLoc
    //EntTime how long to enter the scene
    public IEnumerator spawnMultDiff(Vector2 source, List<Vector2> LocList, List<Vector2> EnterList, 
        List<float> EntTime, float SpawnNum, float delay)
    {
       for(int i = 0; i < LocList.Count; i++)
        {
            yield return new WaitForSeconds(delay);
            Debug.Log("Spawning?" + LocList[i] + source + SpawnNum);
            StartCoroutine(spawnFunct(source, LocList[i], SpawnNum, EnterList[i], EntTime[i]));
        }
    }

 
}
