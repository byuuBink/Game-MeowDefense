using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    float nextFire;

    [SerializeField] private AudioSource shootSoundEffect;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            shootSoundEffect.Play();
        }
        
    }

}