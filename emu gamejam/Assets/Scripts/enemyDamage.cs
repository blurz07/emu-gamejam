using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public float health;
    public float max_health = 3f;
    private HealthBar healthbar;
    private int randNum;
    public GameObject HealthObject;
    public Transform Enemy;

    private void Start()
    {
        health = max_health;
        
    }

    private void Update()
    {
        healthbar = GetComponentInChildren<HealthBar>();
        Enemy = GetComponent<Transform>();
    }

    public void TakeDamage(float damageAmount)
    {
        randNum = Random.Range(0, 99);
        health -= damageAmount;
        healthbar.HealthBarUpdate(health, max_health);
        if (health <= 0) 
        { 
            if(randNum >= 75) {
                Instantiate(HealthObject,new Vector3(Enemy.position.x,Enemy.position.y,Enemy.position.z), Quaternion.identity);
                }
            Destroy(gameObject);
        }
    }
}
