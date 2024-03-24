using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public float health;
    public float max_health = 3f;
    [SerializeField] private HealthBar healthbar;


    private void Start()
    {
        health = max_health;
        healthbar.HealthBarUpdate(health, max_health);
    }

    private void Update()
    {
        healthbar = GetComponentInChildren<HealthBar>();
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthbar.HealthBarUpdate(health, max_health);
        if (health <= 0) 
        { 
            Destroy(gameObject);
        }
    }
}
