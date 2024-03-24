using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject Blood;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.TryGetComponent<enemyDamage>(out enemyDamage enemyComponent))
        {
            enemyComponent.TakeDamage(1);
            Instantiate(Blood, transform.position, Quaternion.identity);
        }

        if (collision.gameObject.TryGetComponent<playerDamage>(out playerDamage playerComponent))
        {
            playerComponent.TakeDamage(1);
            Instantiate(Blood, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);

    }
}
