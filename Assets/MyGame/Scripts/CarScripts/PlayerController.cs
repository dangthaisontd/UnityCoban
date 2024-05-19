using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public float speed = 20;
    private Vector3 targetPositon;

    public float steerAmount = 160;
    public float moveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
       // transform.position = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pointA.position)
        {
            targetPositon = pointB.position;
        }
       else if (transform.position == pointB.position)
        {
            targetPositon = pointC.position;
        }
        else if (transform.position == pointC.position)
        {
            targetPositon = pointD.position;
        }
        else if (transform.position == pointD.position)
        {
            targetPositon = pointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPositon, speed * Time.deltaTime);
        transform.LookAt(targetPositon);
       
       /* float XInput = Input.GetAxis("Horizontal") * Time.deltaTime * steerAmount;
        float ZInput = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Rotate(0, XInput, 0);
        transform.Translate(0, 0, ZInput);
       */
    }
}
