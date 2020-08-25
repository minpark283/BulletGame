using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_LevelSelection : MonoBehaviour {

	public List<List<Button>> arealist;
	// Use this for initialization
	void Start () {
		arealist = new List<List<Button>>(6);
		for(int i = 0; i < 6; i++)
		{
			arealist[0] = new List<Button>();
		}	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
