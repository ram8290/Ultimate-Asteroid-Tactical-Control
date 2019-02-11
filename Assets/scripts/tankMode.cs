using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMode : MonoBehaviour
{

    public Rigidbody2D rb;
    public Transform tf;
    public float moveSpeed;
    public float turnSpeed;
    public float angle;
    public GameObject bullet;
    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * (Time.deltaTime * moveSpeed));
        }

        if (Input.GetKey(KeyCode.S))
        {

            rb.AddForce(-transform.up * (Time.deltaTime * moveSpeed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            angle += (turnSpeed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.GetKey(KeyCode.D))
        {
            angle -= (turnSpeed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

   void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
            ShootBullet();
    }

    void OnTriggerEnter2D(Collider2D c)
    {

        // Anything except a bullet is an asteroid
        if (c.gameObject.tag != "ufoTroid")
        {

            // Move the ship to the centre of the screen
            transform.position = new Vector3(0, 0, 0);

            // Remove all velocity from the ship
            GetComponent<Rigidbody2D>().
                velocity = new Vector3(0, 0, 0);

            gameController.DecrementLives();
        }
    }


    void ShootBullet()
    {

        // Spawn a bullet
        Instantiate(bullet,
            new Vector3(transform.position.x, transform.position.y, 0),
            transform.rotation);

    }

}
