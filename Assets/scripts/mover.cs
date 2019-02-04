using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    public float speed;
    private Transform ship;
	// Use this for initialization
	void Start () {
        ship = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			Debug.Log ("left arrow");
            ship.position = ship.position + (Vector3.left * speed);
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			Debug.Log ("right arrow");
            ship.position = ship.position + (Vector3.right * speed);
        }
		if (Input.GetKey (KeyCode.UpArrow))
		{
			Debug.Log ("up arrow");
            ship.position = ship.position + (Vector3.up * speed);
        }
		if (Input.GetKey (KeyCode.DownArrow))
		{
			Debug.Log ("down arrow");
            ship.position = ship.position + (Vector3.down * speed);
        }
		if (Input.GetKey (KeyCode.Space))
		{
            Debug.Log("spacebar");
            ship.position = new Vector3(0, 0, 0);
		}
	}
}
