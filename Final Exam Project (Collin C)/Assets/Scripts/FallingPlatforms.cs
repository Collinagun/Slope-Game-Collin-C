// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class FallingPlatforms : MonoBehaviour
// {
//     // Variables
//     float intY = 0f;
//     int counter = 500;
//     public WaitForSeconds timer { get; private set;}
//     [SerializeField] private float fallTime;
//     void Start()
//     {
        
//     }

    
//     void FixedUpdate()
//     {
//         transform.Translate(0, intY, 0);
//     }

//     void OnCollisionStay(Collision col)
//     {
//         if (col.gameObject.tag == "Player")
//         {
//             intY = 0f;
//         }
//     }
    
//     void OnCollisionExit(Collision col)
//     {

//         while (counter <= 500)
//         {
//             counter--;
//         }
        
//         intY = -0.1f;
//         counter = 2000;
//         while (counter <= 2000)
//         {
//             counter--;
//         }
//         Destroy(col.gameObject);
        
//     }
// }
