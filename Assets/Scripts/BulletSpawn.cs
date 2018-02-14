using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BulletSpawn : MonoBehaviour {
	public float lives;
	public float spawnTime;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn ()
	{
		if (lives <= 0)
			return;

		System.Random rnd = new System.Random ();

		Instantiate (bullet, new Vector3 (rnd.Next (-24, 24), rnd.Next (-24, 24), 25), Quaternion.identity);
	}
}
