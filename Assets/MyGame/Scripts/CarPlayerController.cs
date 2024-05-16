using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Transactions;
using Unity.Burst.CompilerServices;
using UnityEngine;
public class CarPlayerController : MonoBehaviour
{   //public 
    
    public float speedMove = 20f;
    public float speedRotate = 100f;
   
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate( new Vector3(0, 0, vertical*speedMove*Time.deltaTime));
        transform.Rotate(new Vector3(0, speedRotate * horizontal * Time.deltaTime, 0));
    }  
}
