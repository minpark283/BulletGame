using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemy_info : MonoBehaviour
{
    public BasicEnemy en;
    public GameObject comp;
    private Rigidbody2D compbody;
    public class BasicEnemy
    {
        GameObject En;
        //Enemy stats
        public float enemyHP;

        //Enemy Physics
        public Rigidbody2D enemyBody;

        public BasicEnemy(GameObject obj, Rigidbody2D bd )
        {
            En = obj;
            enemyHP = 100;
            enemyBody = obj.GetComponent<Rigidbody2D>();
        }
        public void TakeDamage(int dmg)
        {

            enemyHP -= dmg;
            Debug.Log("Enemy shot!" +
                "/n current hp: " + enemyHP);
            {
                if (enemyHP <= 0)
                {
                    Destroy(En);
                }
            }
        }
        
        public IEnumerator moveTo(Vector2 targetLocation, float timeToMove)
        {
          
            float dist = Vector2.Distance(En.transform.position, targetLocation);
            float spd = dist / timeToMove;
            float angle = Mathf.Atan2(targetLocation.y - En.transform.position.y, targetLocation.x - En.transform.position.x);
            Vector2 vectorspd = new Vector2(spd * Mathf.Cos(angle), spd * Mathf.Sin(angle));
            enemyBody.velocity = vectorspd;
            yield return new WaitForSeconds(timeToMove);
            Debug.Log("Tried Moving" + dist + enemyBody.transform.position + "with spd" + vectorspd);
            enemyBody.velocity = new Vector2(0,0);
        }

        //takes in ArrayList[] delays, delays for each movement and ArrayList of Vector2
        //to define AI movement behavior.
        public IEnumerator AIMovementWithArray(List<Vector2> locations, List<float>[] delays, List<float> toMove)
        {
            for (int i = 0; i < delays.Length; i++)
            {
                yield return new WaitForSeconds(delays[i].Count);
              //  StartCoroutine(moveTo(locations[i], toMove[i]);
            }
        }

    }
    // Use this for initialization
    void Start()
    {
        compbody = comp.GetComponent<Rigidbody2D>();
        en = new BasicEnemy(comp, compbody);
        
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            int dmgtype = collision.gameObject.GetComponent<Scr_BulletAfterEff>().guntype;
            switch(dmgtype)
            {
            case 0:
                en.TakeDamage(10);
                break;
            case 1:
                en.TakeDamage(7);
                break;
            case 2:
                en.TakeDamage(8);
                break;
            }
            
        }
    }
}
