using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesC : Vaticanais
{
    bool range;
    void Start()
    {
        pv = 10;
    }

    void Update()
    {
        cooldown -= Time.deltaTime;
        timerSFX -= Time.deltaTime;
        Death();

        if (!range)
        {
            follow();
        }

        else if (range)
        {
            if (cooldown < 0)
                Shoot();
        }
    }

    public void SetRange(bool change)
    {
        range = change;
    }

    public void Shoot()
    {
        AudioManager.instance.sfxSource[2].PlayOneShot(AudioManager.instance.sfx[5], 0.1f);
        animWalk.SetTrigger("isShooting");
        Quaternion rotation1 = Quaternion.Euler(0, 0, aim.transform.rotation.eulerAngles.z + 45);
        Quaternion rotation2 = Quaternion.Euler(0, 0, aim.transform.rotation.eulerAngles.z - 45);
        GameObject ball = Instantiate(bullet, aim.transform.position, aim.transform.rotation);
        GameObject ball1 = Instantiate(bullet, aim.transform.position, rotation1);
        GameObject ball2 = Instantiate(bullet, aim.transform.position, rotation2);
        ball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * ball.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);
        ball1.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * ball1.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);
        ball2.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * ball2.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);
        ball.GetComponent<Pompe>().SetBool(true);
        ball1.GetComponent<Pompe>().SetBool(true);
        ball2.GetComponent<Pompe>().SetBool(true);
        cooldown = maxCooldown;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
