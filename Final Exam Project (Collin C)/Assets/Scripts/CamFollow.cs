// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CamFollow : BallController
// {
    
//     Rigidbody rb;
//     float moveX = 0f;
//     float moveY = 0f;
//     float moveZ = 0f;

//     float posX = 0f;
//     float posZ = 0f;

//     int count = 0;
//     // int time = 1000;


//     void Awake()
//     {
//         rb = GetComponent<Rigidbody>();
    
//     }

    
//     void Update()
//     {
//         // When the left mouse button is pressed, sets the movement variable to 0.1 to start the game
//         posX = Positions(inputX);
//         posZ = Positions(inputZ);
        
//     }

//     void FixedUpdate()
//     {
//         transform.Translate(posX - 11, 0.9 + 16,posZ - 14);
//     }

//     void OnCollisionStay(Collision col)
//     {
//         if (col.gameObject.tag == "Ground")
//         {
//             moveY = 0f;
//         }
//     }
    
//     void OnCollisionExit(Collision col)
//     {
//         Destroy(col.gameObject);
        
        
//     }
    
// }
