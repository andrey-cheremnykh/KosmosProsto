using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hp = 100;
    [SerializeField] TMP_Text hpText;
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
        hpText.text = "HP: " + hp;
        if (hp == 0) Destroy(gameObject);
    }
}
