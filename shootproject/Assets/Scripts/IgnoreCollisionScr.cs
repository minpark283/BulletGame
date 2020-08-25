using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(9, 12);
        Physics2D.IgnoreLayerCollision(10, 12);
        Physics2D.IgnoreLayerCollision(11, 12);
        Physics2D.IgnoreLayerCollision(12, 12);
        Physics2D.IgnoreLayerCollision(10, 11);
        Physics2D.IgnoreLayerCollision(10, 10);
        Physics2D.IgnoreLayerCollision(8, 10);
        Physics2D.IgnoreLayerCollision(8, 9);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
