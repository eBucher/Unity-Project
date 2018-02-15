using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BulletSpawn : MonoBehaviour {
	//public float lives;
	public float spawnTime;
	public GameObject bullet;
    private static System.Random rnd = new System.Random();

    // Use this for initialization
    void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void Spawn ()
	{
		if (GameObject.Find("Score Manager").GetComponent<score_mngr>().getLives() <= 0)
			return;

		int halfWallWidth = (int) (GameObject.Find("Wall").transform.lossyScale.x / 2);
		int halfWallHeight = (int) (GameObject.Find("Wall").transform.lossyScale.y / 2);

		//Determine where the bullet is going to be moving towards
		Vector3 startPoint = GameObject.Find ("Wall").transform.position;
		startPoint.x += rnd.Next(-halfWallWidth, halfWallWidth);
		startPoint.y += rnd.Next(-halfWallHeight, halfWallHeight);
		startPoint.z -= 5;

		Instantiate (bullet, startPoint, Quaternion.identity);
        //Instantiate (bullet, new Vector3 (rnd.Next (-24, 24), rnd.Next (-24, 24), 25), Quaternion.identity);
	}
}
