using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{
    // Variables
    Rigidbody rb;
    float moveX = 0f;
    float moveY = 0f;
    float moveZ = 0f;
    // public float inputX = 0f;
    // public float inputZ = 0f;
    

    int count = 0;
    // int time = 1000;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    
    }

    // protected void Positions()
    // {
    //     inputX = Input.GetAxis("Horizontal");
    //     inputZ = Input.GetAxis("Vertical");
    // }

    
    void Update()
    {
        // When the left mouse button is pressed, sets the movement variable to 0.1 to start the game
        if (Input.GetMouseButtonDown(0))
        {
            if (count == 0){
                moveX = 0.1f;
                moveZ = 0f;
                count++;
            }
            else {
                moveX = 0f;
                moveZ = 0.1f;
                count--;
            }
        }
        
    }

    void FixedUpdate()
    {
        transform.Translate(moveX, moveY, moveZ);
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            moveY = 0f;
        }
    }
    
    void OnCollisionExit(Collision col)
    {
        moveY = -0.1f;
        
        Debug.Log("You lost.");
        
    }

}
