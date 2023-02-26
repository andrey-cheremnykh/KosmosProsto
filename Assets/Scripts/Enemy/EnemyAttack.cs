using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 20;
    //float delay = 5;
    PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7) player.GetDamage(damage);
    }

    /*  // Update is called once per frame
      void Update()
      {
          StartCoroutine(Shoot());
      }
      IEnumerator Shoot()
      {
          yield return new WaitForSeconds(delay);
          float distance = Mathf.Infinity;
          RaycastHit hitInfo;
          bool isHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, distance, 7);
          if (isHit)
          {
              if (player)
              {
                  player.GetDamage(damage);

              }
          }

      }*/
}
