using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Equip : MonoBehaviour {
    public GameObject Player;
    private GameObject Gun;

	public GameObject[] gunlisty;
    public GameObject[] bulletlisty;
    // Use this for initialization
    void Start() {
        Gun = gameObject;

		gunlisty[0].SetActive(true);
		gunlisty[1].SetActive(false);
		gunlisty[2].SetActive(false);
    }             
	
	// Update is called once per frame
	void Update () {
        Gun.transform.position = Player.transform.position;
	}

    //Updating the gun
    public void GunUpdate(int selectNum)
	{
		//Check all guns and equip the current one
		//May Need to update this script
		for(int i = 0; i< 3; i++)
		{	
			gunlisty[i].SetActive(false);
		}
		gunlisty[selectNum].SetActive(true);
	}

    /*
    public class GunType
    {
        int fireRate, bulletSpd, bulletDmg;
        Sprite gunModel, bulletModel;

        //Constructor for GunType
        GunType(int fRate, int bSpd, int bDmg,
            Sprite gModel, Sprite bModel)
        {

            fireRate = fRate;
            bulletSpd = bSpd;
            bulletDmg = bDmg;
            gunModel = gModel;
            bulletModel = bModel;

        }

    }
    */
}
