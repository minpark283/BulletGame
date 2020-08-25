using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_bg_effect_spawner : MonoBehaviour {

    private float timer;
    public GameObject Light;
    private Vector3 RLocation;
    public Transform CameraXloc;
    // Use this for initialization
    void Start () {
        timer = 0;
        RLocation = new Vector3(0, 0, 0);
          StartCoroutine(SpawnLight());
	}

    IEnumerator SpawnLight()
    {
        while(true)
        {
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(.1f);
            var rY = Random.Range(-2f, 3.5f);
            var xScale = Random.Range(3, 6);
            var yScale = Random.Range(0.1f, .5f);
            var xLoc = CameraXloc.position.x + 7;
            RLocation = new Vector3(xLoc, rY, 0);
            var beam = (GameObject)Instantiate(Light, RLocation, Quaternion.identity);
            beam.transform.localScale = new Vector3(xScale, yScale, -10);

        }
        yield return new WaitForSeconds(Random.Range(0,0.5f));
        }

    }  
}
