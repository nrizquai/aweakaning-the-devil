using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesD : Vaticanais
{
    public Queue<GameObject> stockball;
    float overlifetime;
    Vector3 dir;
    
    GameObject ball = null;
    private void Start()
    {
        pv = 10;
    }
    public override void follow()
    {
        if(cooldown > 0)
        {
            base.follow();
        }
        else if(cooldown < 0)
        {
            animWalk.SetTrigger("isShooting");
            GameObject ball = Instantiate(bullet, aim.transform.position, aim.transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * ball.GetComponent<Bille200>().GetProjSpeed(), ForceMode2D.Impulse);
            ball.GetComponent<Bille200>().SetBool(true);
            cooldown = maxCooldown;
        }
    }


    private void Update()
    {
        cooldown -= Time.deltaTime;
        timerSFX -= Time.deltaTime;
        follow();
        Death();
    }

}
