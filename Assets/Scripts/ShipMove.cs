using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    [SerializeField] bool Throttle => Input.GetKey(KeyCode.Space);
    [SerializeField] float pitchPower, rollPower, yawPower, enginePower;
    float activePitch, activeRoll, activeYaw;
    
    private void Update()
    {
        if (Throttle)
        {
            transform.position += transform.forward * enginePower * Time.deltaTime;
            activePitch = Input.GetAxisRaw("Vertical") * pitchPower * Time.deltaTime; 
            activeRoll = Input.GetAxisRaw("Horizontal") * pitchPower * Time.deltaTime; 
            activeYaw = Input.GetAxisRaw("Yaw") * pitchPower * Time.deltaTime;

            transform.Rotate(activePitch * pitchPower * Time.deltaTime
                , activeYaw * yawPower * Time.deltaTime
                , activeRoll * rollPower * Time.deltaTime, Space.Self);

        }
    }
}
