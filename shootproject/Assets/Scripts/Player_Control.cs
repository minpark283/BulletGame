using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    //Player stats
    private float playerHP;
    private float playerEN;

    //Player Physics Property
    private Rigidbody2D player;
    private float pspeed = 5f;
    private float moveX;
    private float moveY;
    private bool canMove;

    //Player UI Property
    public GameObject playerHpUI;
    private Slider playerHpbar;
    public GameObject playerEnUI;
    private Slider playerEnbar;

    //Gun Property
    public float fireRate;
    private float nextFire = 0.0F;
  

    //Temp Gun Info
    public Scr_Bullet BulletAtk;
 


    private int gunselectnum;
    private int gunMax;
    public Player_Equip GunEquip;

    // Use this for initialization
    void Start()
    {
        playerHP = 100;
        playerEN = 100;
        gunselectnum = 0;
        gunMax = 3;
        canMove = true;
        player = gameObject.GetComponent<Rigidbody2D>();
        playerHpbar = playerHpUI.GetComponent<Slider>();
        playerEnbar = playerEnUI.GetComponent<Slider>();
     
        playerHpbar.value = playerHP;
        playerEnbar.value = playerEN;
       
      
    }


    void FixedUpdate()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        //Shooting
        if(Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            BasicAtk();
        }
        //Switching Weapons
        if(Input.GetKeyDown(KeyCode.X))
        {
            SwitchWeapon();
        }
        //Physics
        player.velocity = new Vector2(moveX * pspeed, moveY * pspeed);
        
    }
    //Atk
    void BasicAtk()
    {
        //TempGun Script
        float num = BulletAtk.SpawnCorrectBullet(gunselectnum, this.gameObject.transform);
        fireRate = num;

        //Accounting for the cooldown of the bullet
        nextFire = Time.time + fireRate;
    }

    //Switch Weapon
    void SwitchWeapon()
    {
        gunselectnum +=1;
        if(gunselectnum == gunMax)
        {
            gunselectnum = 0;
        }
        GunEquip.GunUpdate(gunselectnum);
    }


   void TakeDamage(float dmg)
    {
        playerHP -= dmg;
        
        //Update Player HP
        playerHpbar.value = playerHP;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            TakeDamage(10);
            Debug.Log("Current HP: " + playerHP);
        }
    }
}
