using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BulletAfterEff : MonoBehaviour {

	private Vector2 lastPosition;
	public int guntype;

	//hitparticle
    public GameObject hitparticle1;

	// Use this for initialization
	void Start () {
		
	}


	void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9) 
        {
			if(guntype == 1)
			{
            	var hit = (GameObject)Instantiate(hitparticle1, this.gameObject.transform.position, this.gameObject.transform.rotation);
            	Destroy(this.gameObject, .01f);
			}
			else
			{
				var hit = (GameObject)Instantiate(hitparticle1, this.gameObject.transform.position, this.gameObject.transform.rotation);
            	Destroy(this.gameObject, .01f);
			}
        }
    }

}
