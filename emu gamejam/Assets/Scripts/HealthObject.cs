using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    public playerDamage x;
    public HealthBar healthBar;
    void Start()
    {
        x = GetComponent<playerDamage>();
        healthBar = GetComponentInChildren<HealthBar>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "HealthObject")
        {
            Destroy(other.gameObject);
            x.CollectedHealth();
            healthBar.HealthBarUpdate(x.health, x.max_health);
        }
        
    }
}
