using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 20;
    float delay = 5;
    PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        Shoot();
    }
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(delay);
        float distance = Mathf.Infinity;
        RaycastHit hitInfo;
        bool isHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, distance, 7);
        if (player)
        {
            player.GetDamage(damage);

        }
    }
}
