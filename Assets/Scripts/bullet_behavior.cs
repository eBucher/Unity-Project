using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_behavior : MonoBehaviour
{

    // Use this for initialization
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed * -1;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
