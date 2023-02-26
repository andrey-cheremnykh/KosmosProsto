using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    ShipMove player;
    Rigidbody rb;
    [SerializeField]float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<ShipMove>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        Vector3 throttle = new Vector3(0, 0, -speed);
        rb.AddRelativeForce(throttle);
    }
    private void OnTriggerEnter(Collider other)
    {
        speed /= 2;
    }private void OnTriggerExit(Collider other)
    {
        speed *= 2;
    }
}
