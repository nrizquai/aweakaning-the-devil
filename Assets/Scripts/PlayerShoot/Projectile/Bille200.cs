using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bille200 : Projectile
{
    void Start()
    {
        Invoke("Destroy", card.dispersion);
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enemy)
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PControl>().TakeDamage(card.damage);
                Destroy();
            }

        if (!enemy)
        {
            if (collision.CompareTag("EnemyD"))
            {
                collision.GetComponent<EnemiesD>().TakeDamage(card.damage);
                Destroy();
            }

            if (collision.CompareTag("EnemyC"))
            {
                collision.GetComponent<EnemiesC>().TakeDamage(card.damage);
                Destroy();
            }
        }
    }
}
