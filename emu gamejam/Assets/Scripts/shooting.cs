using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public int currentClip = 10;
    public int maxClip = 10;
    public Text ammodisplay;
    public Text maxammodisplay;

    public float bulletForce = 20f;
    
    void Update()
    {
        maxammodisplay.text = maxClip.ToString();
        ammodisplay.text = currentClip.ToString();
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

    }

    void Shoot()
    {
        if (currentClip > 0)
        {
            GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            currentClip--;
        }
    }

    public void Reload()
    {
        currentClip = maxClip;
    }
}
