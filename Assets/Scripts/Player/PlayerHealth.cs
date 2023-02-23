using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hp = 100;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void GetDamage(float damage)
    {
        hp -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0) Destroy(gameObject);
    }
}
