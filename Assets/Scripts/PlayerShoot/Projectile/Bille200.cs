using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bille200 : Projectile
{
    void Start()
    {
        Invoke("Destroy", usedCard.dispersion);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enemy)
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PControl>().TakeDamage(usedCard.damage);
                Destroy();
            }

        if (!enemy)
        {
            if (collision.CompareTag("EnemyD"))
            {
                collision.GetComponent<EnemiesD>().TakeDamage(usedCard.damage);
                Destroy();
            }

            if (collision.CompareTag("EnemyC"))
            {
                collision.GetComponent<EnemiesC>().TakeDamage(usedCard.damage);
                Destroy();
            }
        }
    }
}
