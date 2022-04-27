using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int startHealth;
    [SerializeField] int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Health :" + currentHealth);
    }

    public void DamageMethod(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth <=0)
        {
            DeathMethod();
            
        }
    }

    public void DeathMethod()
    {
        gameObject.SetActive(false);
        //Debug.Log("Health :" + currentHealth);
    }
}
