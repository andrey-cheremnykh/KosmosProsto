using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrust;
    [SerializeField] float rotateSpeed;
    [SerializeField] float maxSpeed;
    LandedMenu lm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lm = FindObjectOfType<LandedMenu>();
    }
    void FixedUpdate()
    {
        Thrust();
        Turn();
        Pitch();
    }
    void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(0, 0, thrust);
            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed; 
            }
        }
    }
    void Turn()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotateSpeed, 0);
        } 
    }
    void Pitch()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotateSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-rotateSpeed, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            lm.landMenu.SetActive(true);
        }
    }
}
