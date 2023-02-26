using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hp = 100;
    [SerializeField]ParticleSystem damageVFX;
    [SerializeField]ParticleSystem deathVFX;
    
    // Update is called once per frame
    void Update()
    {
        if (hp < 0) 
        {
            StartCoroutine(Death());
        }
    }
    public void GetDamage(float damage)
    {
        hp -= damage;
        damageVFX.Play();
    }
    IEnumerator Death()
    {

        deathVFX.Play();
        yield return new WaitForSeconds(1);
        if(transform.tag == "Enemy Fighter")
        {
            EnemyReward er = FindObjectOfType<EnemyReward>();
            er.ScorePoints(20);
            Destroy(gameObject);
        } 
        else if(transform.tag == "Enemy Destroyer")
        {
            EnemyReward er = FindObjectOfType<EnemyReward>();
            er.ScorePoints(40);
            Destroy(gameObject);
        }
    }
}
