using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouleDeFeu : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", usedCard.dispersion);
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
                collision.GetComponent<PControl>().TakeDamage(cardsList[2].damage);
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
