using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Bullet : MonoBehaviour
{
   
    //Bullet Offset
    protected Vector3 Bulletoffset;

    //Bullet Type
    public GameObject BulletObj1;
    public GameObject BulletObj2;
    public GameObject BulletObj3;

    /* 
    private Bullet1 b1;
    private Bullet2 b2;
    private Bullet3 b3;
    */
    // Use this for initialization
    void Start()
    {
        /* 
        b1 = new Bullet1();
        b2 = new Bullet2();
        b3 = new Bullet3();
        */
        Bulletoffset = new Vector3(0, .13f, 0);
        /* 
        bulletbody = gameObject.GetComponent<Rigidbody2D>();
        lastPosition = gameObject.transform.position;
        bulletbody.velocity = new Vector2(20, 0);
        */
    }

    public float SpawnCorrectBullet(int selector, Transform loc)
    {
        //Debug.Log(b1.fireRate);
        if(selector == 0)
        {
            GameObject pbullet = Instantiate(BulletObj1, loc.position + Bulletoffset, loc.rotation) as GameObject;
            pbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(20, 0);
            Destroy(pbullet, 2f);
            return 0.1f;
        }
        else if(selector == 1)
        {
            //TempGun Script
            GameObject pbullet1 = Instantiate(BulletObj2, loc.position + Bulletoffset, loc.rotation) as GameObject;
            GameObject pbullet2 = Instantiate(BulletObj2, loc.position + Bulletoffset, loc.rotation) as GameObject;
            GameObject pbullet3 = Instantiate(BulletObj2, loc.position + Bulletoffset, loc.rotation) as GameObject;
            pbullet1.GetComponent<Rigidbody2D>().velocity = new Vector2(13, -13);
            pbullet2.GetComponent<Rigidbody2D>().velocity = new Vector2(13, 0);
            pbullet3.GetComponent<Rigidbody2D>().velocity = new Vector2(13, 13);
            Destroy(pbullet1, 2f);
            Destroy(pbullet2, 2f);
            Destroy(pbullet3, 2f);
            return 0.2f;    
        }
        else if(selector == 2)
        {
            //TempGun Script
            GameObject pbullet = Instantiate(BulletObj3, loc.position + Bulletoffset, loc.rotation) as GameObject;
            pbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(15, 0);
            Destroy(pbullet, 2f);
            return 0.15f;
        }
        return 0f;
    }
    

    //protected abstract void SpawnBullet(Transform location);



   
    
}
/* 
public class Bullet1 : Scr_Bullet
{
    public float fireRate = 0.1f;
    int dmg = 10;
    public void SpawnBullet(Transform location)
    {
        //TempGun Script
        GameObject pbullet = Instantiate(BulletObj1, location.position + Bulletoffset, transform.rotation) as GameObject;
        pbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(20, 0);
        Destroy(pbullet, 2f);
       
    }
}

public class Bullet2 : Scr_Bullet
{
    public float fireRate = 0.2f;
    float nextFire = 0.0F;
    int dmg = 8;
    public void SpawnBullet(Transform location)
    {
        //TempGun Script
        GameObject pbullet = Instantiate(BulletObj2, location.position + Bulletoffset, transform.rotation) as GameObject;
        pbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(15, 0);
        Destroy(pbullet, 2f);
    }
}

public class Bullet3 : Scr_Bullet
{
    public float fireRate = 0.2f;
    float nextFire = 0.0F;
    int dmg = 5;
    public void SpawnBullet(Transform location)
    {
        //TempGun Script
        GameObject pbullet1 = Instantiate(BulletObj3, location.position + Bulletoffset, transform.rotation) as GameObject;
        GameObject pbullet2 = Instantiate(BulletObj3, location.position + Bulletoffset, transform.rotation) as GameObject;
        GameObject pbullet3 = Instantiate(BulletObj3, location.position + Bulletoffset, transform.rotation) as GameObject;
        pbullet1.GetComponent<Rigidbody2D>().velocity = new Vector2(13, -13);
        pbullet2.GetComponent<Rigidbody2D>().velocity = new Vector2(13, 0);
        pbullet3.GetComponent<Rigidbody2D>().velocity = new Vector2(13, 13);
        Destroy(pbullet1, 2f);
        Destroy(pbullet2, 2f);
        Destroy(pbullet3, 2f);
    }
}
*/