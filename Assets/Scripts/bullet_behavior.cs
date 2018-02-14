using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bullet_behavior : MonoBehaviour
{

    // Use this for initialization
    public float speed;
	private Vector3 bul_dir;
	private Vector3 endPoint;
    private static System.Random rnd = new System.Random();

    void Start()
    {
		bul_dir = GameObject.Find ("PlayerHitbox").transform.position - transform.position;
		GetComponent<Rigidbody>().AddForce(bul_dir * speed);

        int halfHitboxWidth = (int) (GameObject.Find("PlayerHitbox").transform.lossyScale.x / 2);
        int halfHitboxHeight = (int) (GameObject.Find("PlayerHitbox").transform.lossyScale.y / 2);

        //Determine where the bullet is going to be moving towards
        endPoint = GameObject.Find ("PlayerHitbox").transform.position;
		endPoint.x += rnd.Next(-halfHitboxWidth, halfHitboxWidth);
		endPoint.y += rnd.Next(-halfHitboxHeight, halfHitboxHeight);
		Debug.Log (endPoint, gameObject);

		//bul_dir = bul_dir * new System.Random ().Next(-24,24);
		//bul_dir = bul_dir * -1;
        //GetComponent<Rigidbody>().velocity = transform.forward * speed * -1;
		//bul_dir = GameObject.Find ("lightsaber").transform.position - transform.position;
			
		//GetComponent<Rigidbody>().AddForce(bul_dir * speed);
    }

    // Update is called once per frame
    void Update()
    {
		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, endPoint, step );
    }
}
