using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PhysicCarController : MonoBehaviour
{
    public float speedMove=20;
    public float speedRotation = 100;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + transform.forward * vertical * speedMove * Time.deltaTime);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, speedRotation * horizontal * Time.deltaTime,0)));
    }
}
