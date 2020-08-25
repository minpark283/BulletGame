using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_level_scroll : MonoBehaviour {

	public float scrollspeed1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//scrollspeed1 = scrollspeed1 * Time.deltaTime;
		transform.Translate(scrollspeed1, 0, 0, Space.World);
	}
}
