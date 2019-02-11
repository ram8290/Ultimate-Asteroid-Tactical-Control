using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{

    public Transform tf;
    public float moveSpeed;
    public GameObject ship;




    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
        ship = GameObject.Find("ship");

        Vector3 localPosition = ship.transform.position - tf.position; // take difference of player location and self location
        localPosition = localPosition.normalized; // normalize
        float angle = Mathf.Atan2(localPosition.y, localPosition.x) * Mathf.Rad2Deg; // vector3 to degrees
        transform.rotation = Quaternion.Euler(0f, 0f, angle); // sets rotation to face player
    }

    void Update()
    {
        tf.position = tf.position + (tf.right * (moveSpeed * Time.deltaTime));
    }

}