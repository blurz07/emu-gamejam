using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    public float health;
    public float max_health = 3f;


    private void Start()
    {
        health = max_health;
    }


    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
 
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
