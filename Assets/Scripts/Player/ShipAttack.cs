using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShipAttack : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform laserOrigin;
    [SerializeField] TMP_Text ammoText;
    float gunRange = Mathf.Infinity;
    [SerializeField] float damage = 20;
    [SerializeField] float fireRate = 0.05f;
    [SerializeField] float laserDuration = 1;
    [SerializeField] float ammo = 100;
    [SerializeField] float ammoMax = 100;
    LineRenderer laserLine;
    float fireTimer;
    private void Awake()
    {
        laserLine = GetComponent<LineRenderer>();

    }
    private void Update()
    {
        ammoText.text = "Ammo: " + ammo + "/" + ammoMax;
        Shoot();
    }
    void Shoot()
    {
        fireTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.G))
        {
            ammo--;
            fireTimer = 0;
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
            RaycastHit hit;
            float distance = Mathf.Infinity;
            bool isHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, 7);
            if(isHit)
            {
                print(hit.transform.name); 
                EnemyHealth en = hit.transform.GetComponent<EnemyHealth>();
                laserLine.SetPosition(1, hit.point);
                if (en)
                {
                    en.GetDamage(damage);
                }
                
            }
            else
            {
                print("no hit"); 
                laserLine.SetPosition(1, rayOrigin + (cam.transform.forward * 1000));
            }
            StartCoroutine(ShootLaser());
        }
    }
    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6) ammo = ammoMax;
    }
}
