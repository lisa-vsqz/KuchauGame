using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 30;
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        // Negate bulletSpawnPoint.right to ensure the bullet moves forward along the x-axis
        bullet.GetComponent<Rigidbody>().velocity = -bulletSpawnPoint.right * bulletSpeed;
    }
    }
}
