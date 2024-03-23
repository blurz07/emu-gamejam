using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        if(collision.gameObject.TryGetComponent<enemyDamage>(out enemyDamage enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        Destroy(gameObject);

    }
}
