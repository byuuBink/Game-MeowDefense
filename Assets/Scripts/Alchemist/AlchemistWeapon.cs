using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemistWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    float nextFire;

    [SerializeField] private AudioSource shootSoundEffect;

    private void Update()
    {
        Shoot();
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
