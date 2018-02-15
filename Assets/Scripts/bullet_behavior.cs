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
		endPoint.z -= 5;
		Debug.Log (endPoint, gameObject);

    }

    // Update is called once per frame
    void Update()
    {
		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, endPoint, step );
    }
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PlayerHitbox")) {
			//Debug.Log ("Collision");
			GameObject.Find("Score Manager").GetComponent<score_mngr>().decrease_lives();
			Destroy (this.gameObject);
		}
		if(other.gameObject.CompareTag ("Lightsaber")) {
			//Debug.Log ("Hit the lightsaber");
			GameObject.Find("Score Manager").GetComponent<score_mngr>().increase_score();
			Destroy (this.gameObject);
	}
}
}