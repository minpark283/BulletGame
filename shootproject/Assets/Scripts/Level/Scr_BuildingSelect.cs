using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BuildingSelect : MonoBehaviour {

	public GameObject [] buildinglist; 
	private int rand;
	//SpriteRenderer m_SpriteRenderer;
	// Use this for initialization
	void Start () {
		rand = Random.Range(0,5);
		//m_SpriteRenderer = buildinglist[rand].GetComponent<SpriteRenderer>();
		for(int i = 0; i < 6; i++)
		{
			buildinglist[i].SetActive(false);
		}
		
        //m_SpriteRenderer.color = new Color(145,145,145);
	
		buildinglist[rand].SetActive(true);
		

		
	}
}
