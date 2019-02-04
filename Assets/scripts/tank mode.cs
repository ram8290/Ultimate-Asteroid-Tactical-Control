using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmode : MonoBehaviour {

    private Transform tf;
    private Rigidbody2D rb2D;
    public float turnSpeed;
    public float moveSpeed;

    public float force;

    private float angle = 0.0f;

	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
    
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.A))
        {
            angle -= turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.GetKey(KeyCode.D))
        {
            angle += turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //tf.Translate(tf.right * moveSpeed * Time.deltaTime, Space.World);
            tf.position += (tf.right * moveSpeed * Time.deltaTime);
            //tf.position += (tf.TransformDirection(Vector3.right) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //tf.Translate(-tf.right * moveSpeed * Time.deltaTime, Space.World);
            tf.position -= (tf.right * moveSpeed * Time.deltaTime);
            //tf.position -= (tf.TransformDirection(Vector3.right) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            rb2D.AddForce(transform.right * force);
        }

    }
}
