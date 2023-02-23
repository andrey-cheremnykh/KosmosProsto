using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttack : MonoBehaviour
{
    float damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        float distance = Mathf.Infinity;
        RaycastHit hitInfo; 
        bool isHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, distance, 7);
            print(hitInfo.transform.name);
        EnemyHealth en = hitInfo.transform.GetComponent<EnemyHealth>();
        if (isHit)
        {
            if (en)
            {
                en.GetDamage(damage);

            }

        }
        
    }
}
