using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    [SerializeField] Vector3 Throttle;
    Rigidbody rb;
    [SerializeField] float rotateSpeed = 5;
    [SerializeField] float pitchPower = 5;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        ApplyThrottle();
        Turn();
        Pitch();
    }
    void ApplyThrottle()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Throttle);
        }

    }
    void Turn()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            Vector3 rotSpeed = new(0, rotateSpeed, 0);
            transform.Rotate(rotSpeed);
        }
    
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            Vector3 rotSpeed = new(0, -rotateSpeed, 0);
            transform.Rotate(rotSpeed);
        }

    }
    void Pitch()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 pPower = new(pitchPower,0 , 0);
            transform.Rotate(pPower);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 pPower = new( -pitchPower, -0,0);
            transform.Rotate(pPower);

        }
    }
}
