using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentDisable : MonoBehaviour
{

    private mover move;
    // Use this for initialization
    void Start()
    {
        move = GetComponent<mover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (move.enabled == true)
            {
                Debug.Log("Pause");
                move.enabled = false;
            }
            else if (move.enabled == false)
            {
                Debug.Log("Unpause");
                move.enabled = true;
            }
        }
       
    }
}