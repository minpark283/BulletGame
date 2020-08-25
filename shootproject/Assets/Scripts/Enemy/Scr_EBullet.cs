using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_EBullet : MonoBehaviour {

    private Rigidbody2D bulletbody;
    private Vector2 lastPosition;
    //hitparticle
    public GameObject hitparticle;


    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {

            var hit = (GameObject)Instantiate(hitparticle, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
