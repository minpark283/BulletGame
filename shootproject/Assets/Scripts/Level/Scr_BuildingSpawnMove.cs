using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BuildingSpawnMove : MonoBehaviour {
	
	public GameObject[] buildinglisty;
	public float buildingspd;
	private int sizelist;
	public float minwaittime;
	public float maxwaittime;
	public float rannum;
	// Use this for initialization
	void Start () {
		sizelist = buildinglisty.Length;
		StartCoroutine(SpawnBuilding());
		
	}
	
	// Update is called once per frame
	void Update () {	
	}

	IEnumerator SpawnBuilding()
	{
		int randomselect = 0;
		while(true)
		{

			//SpawnBuilding Script
			randomselect = (int)Random.Range(0, sizelist);
			GameObject blockbuilding = Instantiate(buildinglisty[randomselect], this.transform.position, this.transform.rotation);
			blockbuilding.GetComponent<Rigidbody2D>().velocity = new Vector2(-1 * buildingspd, 0);

			Destroy(blockbuilding, 5);
			rannum = Random.Range(minwaittime, maxwaittime);
			yield return new WaitForSeconds(rannum);

			//Completed Version
			//yield return new WaitForSeconds(buildingspd + offsetlist[randomselect]);

		}
	}
}
