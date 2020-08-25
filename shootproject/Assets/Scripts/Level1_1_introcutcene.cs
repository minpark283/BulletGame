using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_1_introcutcene : MonoBehaviour
{
    Scr_EnemySpawn spawner1;
    public GameObject cameraPos;
    public GameObject lightspawner;
    public GameObject dialgoueBox;
    public GameObject diaPic;
    public GameObject spaceShipDoor;
    public GameObject SpaceShip;
    private Rigidbody2D SpaceShipBody;

    // Use this for initialization
    void Start()
    {

        diaPic.SetActive(false);
        dialgoueBox.SetActive(false);
        spaceShipDoor.SetActive(false);
        SpaceShipBody = SpaceShip.GetComponent<Rigidbody2D>();
        SpaceShipBody.velocity = new Vector2(2f, 0);
        StartCoroutine(CutScene1());
        spawner1 = transform.GetComponent<Scr_EnemySpawn>();

    }

    // Update is called once per frame
    void Update()
    {

    }



    IEnumerator CutScene1()
    {

        yield return new WaitForSeconds(5.5f);
     
        SpaceShipBody.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(1.5f);
        Vector2 source = cameraPos.transform.position;
        List<Vector2> loclist = new List<Vector2>();
        List<Vector2> entList = new List<Vector2>();
        List<float> EnterTime = new List<float>();
        loclist.Add(new Vector2(5, 4));
        loclist.Add(new Vector2(8, 2.5f));
        loclist.Add(new Vector2(8, 0));
        entList.Add(new Vector2(3, 2));
        entList.Add(new Vector2(3, 1f));
        entList.Add(new Vector2(3, 0));
        EnterTime.Add(1);
        EnterTime.Add(1);
        EnterTime.Add(1);
        StartCoroutine(spawner1.spawnMultDiff(source, loclist, entList, EnterTime, 1, 0f));
        yield return new WaitForSeconds(6.5f);
        for(int i = 0; i < spawner1.SpawnList.Count; i++)
        {
            spawner1.SpawnList[i].GetComponent<Enemy_aimbotShoot>().ShootEnable = false;
        }
        yield return new WaitForSeconds(1.0f);
        SpaceShipBody.velocity = new Vector2(-.1f, .5f);
        yield return new WaitForSeconds(2f);
        SpaceShipBody.velocity = new Vector2(0, 0);
    }
}