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
        stockball = new Queue<GameObject>();
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
            GameObject ball = Instantiate(bullet, aim.transform.position, aim.transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * ball.GetComponent<Bille200>().GetProjSpeed(), ForceMode2D.Impulse);
            ball.GetComponent<Bille200>().SetBool(true);
            cooldown = maxCooldown;
            //stockball.Enqueue(ball);
        }
    }


    private void Update()
    {
        //float speed = 10;
        /*Vector2 pos = transform.position - _target.position;
        if (pos.x > 0 && (pos.y > -0.5 && pos.y < 0.5))
        {
            dir.x = speed * Time.deltaTime;
            dir.y = 0;
        }
        if (pos.x < 0 && (pos.y > -0.5 && pos.y < 0.5))
        {
            dir.x = -speed * Time.deltaTime;
            dir.y = 0;
        }


        if (pos.y > 0 && (pos.x > -0.5 && pos.x < 0.5))
        {
            dir.y = speed * Time.deltaTime;
            dir.x = 0;
        }
        if (pos.y < 0 && (pos.x > -0.5 && pos.x < 0.5))
        {
            dir.y = -speed * Time.deltaTime;
            dir.x = 0;
        }*/


        cooldown -= Time.deltaTime;
        /*overlifetime += Time.deltaTime;
        if(cooldown > 2)
        {
            cooldown = -1;
            ball = null;
        }
        if(overlifetime > 5)
        {
            overlifetime = 0;
            if(stockball.Count > 0)
            {
                GameObject b = stockball.Dequeue();
                Destroy(b);
            }
        }*/
        follow();
        Death();
    }
}
