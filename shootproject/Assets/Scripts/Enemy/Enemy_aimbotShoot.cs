using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_aimbotShoot : MonoBehaviour {
    
    //Unit Info
    Scr_Enemy_info.BasicEnemy EnInfoScript;
    public GameObject unit;

    //Bullet
    public GameObject EBullet;

    //TargetInfo
    public GameObject btarget;

    //Timer Ai Shooting
   
    private float detAct;
    public bool ShootEnable;
    void Start () {
        //EnInfoScript = transform.GetComponent<Scr_Enemy_info>();
        EnInfoScript = new Scr_Enemy_info.BasicEnemy(unit, unit.GetComponent<Rigidbody2D>());
        ShootEnable = true;
      
        StartCoroutine( EntranceDelayShoot(3));
        StartCoroutine(EnemyAI());
    }

   
    IEnumerator EnemyAI()
    {
        while(EnInfoScript.enemyHP > 0)
        {

            yield return new WaitForSeconds(3);
            if (ShootEnable == true)
            {
                detAct = Random.Range(0, 3);
                if (detAct < 2)
                {
                    //Debug.Log("Shot" + detAct);
                    Shoot(btarget, 8.5f);
                   
                }
                else
                {
                    // Debug.Log("MultiShot" + detAct);
                    StartCoroutine(multShoot(btarget));
                   
                }
            }
        }


    }
    void Shoot(GameObject target, float bspeed)
    {
       
        Vector2 direction = (target.transform.position - EnInfoScript.enemyBody.transform.position).normalized;
        GameObject shoot = (GameObject)Instantiate(EBullet, EnInfoScript.enemyBody.transform.position, Quaternion.identity);
        shoot.GetComponent<Rigidbody2D>().velocity = direction * bspeed;
        Destroy(shoot, 2f);
    }
    IEnumerator multShoot(GameObject target)
    {
        for(int i = 0; i < 3; i ++)
        {
            yield return new WaitForSeconds(.1f);
            Shoot(target, 5);
        }
    }
    

    IEnumerator EntranceDelayShoot(float delay)
    {
        ShootEnable = false;
       
        yield return new WaitForSeconds(delay);
        ShootEnable = true;
    }
}
