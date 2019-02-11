using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
    public Transform tf;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, 10.0f);

        // Push the bullet in the direction it is facing
        GetComponent<Rigidbody2D>()
            .AddForce(transform.up * (moveSpeed * Time.deltaTime));
    }

}