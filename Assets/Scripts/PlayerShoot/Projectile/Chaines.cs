using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaines : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", card.dispersion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemy)
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
