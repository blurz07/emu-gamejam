using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.TryGetComponent<enemyDamage>(out enemyDamage enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        if (collision.gameObject.TryGetComponent<playerDamage>(out playerDamage playerComponent))
        {
            playerComponent.TakeDamage(1);
        }

        Destroy(gameObject);

    }
}
