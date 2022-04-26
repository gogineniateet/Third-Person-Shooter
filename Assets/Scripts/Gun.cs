using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 1.5f)]
    float fireRate = 1f;
    [SerializeField]
    [Range(1f, 10f)]
    int damageRate = 1;

    public GameObject firePoint;
    [SerializeField]
    ParticleSystem particleSystem;


    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer >= fireRate)
        {
            if(Input.GetButton("Fire1"))
            {
                timer = 0f;
                ToFireGun();
            }
        }
    }

    private void ToFireGun()
    {
        particleSystem.Play();
            // add  audio source
        Debug.DrawRay(firePoint.transform.position, transform.forward * 100, Color.red, 1f);
        Ray ray = new Ray(firePoint.transform.position, transform.forward);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray,out hitInfo,100f))
        {
            // need to shoot the enemy 
            var health = hitInfo.collider.GetComponent<EnemyController>();
            Debug.Log(health);
            if(health != null)
            {
                health.DamageMethod(10);
            }
        }
    }
}
