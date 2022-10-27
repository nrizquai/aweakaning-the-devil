using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouleDeFeu : Projectile
{
    public SpriteRenderer chickenImage;
    void Start()
    {
        Invoke("Destroy", usedCard.dispersion);
        AudioManager.instance.sfxSource[2].PlayOneShot(AudioManager.instance.sfx[2], 0.3f);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemy)
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PControl>().TakeDamage(cardsList[2].damage,1,0);
                Destroy();
            }

        if (!enemy)
        {
            if (collision.CompareTag("EnemyD"))
            {
                collision.GetComponent<EnemiesD>().TakeDamage(usedCard.damage,0,1);
                Destroy();
            }

            if (collision.CompareTag("EnemyC"))
            {
                collision.GetComponent<EnemiesC>().TakeDamage(usedCard.damage,0,1);
                Destroy();
            }
        }
        if (collision.CompareTag("Wall"))
            Destroy(gameObject);
    }
}
