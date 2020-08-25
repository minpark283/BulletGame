using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class Testing : MonoBehaviour
{
    public float playerSpeed;
    public float rotateSpeed;
    public float fireRate;
    private float moveX;
    private float moveY;
    public Transform bulletSpawn;
    public GameObject bullet;
    public GameObject hitParticle;
    public LayerMask enemyLayer;

    private Rigidbody2D player;
    private float lastFire = 0f;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        // Movement
        player.velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);

        Shoot(); // Shoot
    }

    void Shoot()
    {
        // Store anything that the ray hits in the enemyLayer here
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 100f, enemyLayer);

        // Shooting code here
        if (Input.GetKey(KeyCode.Space) && Time.time > fireRate + lastFire)
        {
            Debug.DrawLine(transform.position, transform.up * 100f, Color.cyan);
            // Checks if the ray hits anything in enemyLayer
            if (hit.collider != null)
            {
                GameObject hitInstance = Instantiate(hitParticle, hit.point, Quaternion.identity) as GameObject;
                // Rotates the particle to direction of surface it hits
                hitInstance.transform.up = hit.normal;
                Destroy(hitInstance, 0.5f);
                Debug.Log("Enemy is hit!");
            }

            GameObject bulletClone = Instantiate(bullet, bulletSpawn.position, transform.rotation) as GameObject;
            Destroy(bulletClone, 2f);
            lastFire = Time.time;
            Debug.Log("Bullet shot!");
        }
    }
}