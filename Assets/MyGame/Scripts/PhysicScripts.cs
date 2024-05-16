using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Bat dau va cham");
        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Van va cham");
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Thoat khoi va cham");
    }

    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Bat dau va cham Triger");
       // Debug.Log(other.name);
    }
    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("Van va cham Triger");
       // Debug.Log(other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Thoat khoi va cham Triger");
       // Debug.Log(other.name);
    }
}
