using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Light_ctrl : MonoBehaviour {
    private Rigidbody2D LightBody;
    public float lightSpeedMin;
    public float lightSpeedMax;
    // Use this for initialization
    void Start () {
        LightBody = gameObject.GetComponent<Rigidbody2D>();
        var rnum = Random.Range(lightSpeedMin, lightSpeedMax);
        LightBody.velocity = new Vector2(rnum, 0);
        Destroy(gameObject, 1f);
    }

}
