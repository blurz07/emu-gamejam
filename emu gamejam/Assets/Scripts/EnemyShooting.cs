using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public Transform enemyFirePoint;
    public GameObject bulletPrefab;
    public GameObject Player;
    private bool haslineofsight = false;
    private bool isFiring;
    public float bulletForce = 20f;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Player.transform.position - transform.position);
        if (ray.collider != null)
        {
            haslineofsight = ray.collider.CompareTag("Player");
            if (haslineofsight && isFiring == false)
            {
                Debug.DrawRay(transform.position, Player.transform.position - transform.position, Color.green);
                StartCoroutine(Shoot());
            }
            else
            {
                Debug.DrawRay(transform.position, Player.transform.position - transform.position, Color.red);
            }
        }
    }

    IEnumerator Shoot()
    {
        isFiring = true;
        GameObject Bullet = Instantiate(bulletPrefab, enemyFirePoint.position, enemyFirePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(enemyFirePoint.up * bulletForce, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.4f);
        isFiring = false;
        yield return null;
    }
}
