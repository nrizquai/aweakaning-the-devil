using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourelle : Vaticanais
{
    float cooldown;
    public GameObject bullet;
    private void Start()
    {
        GameObject ball = Instantiate(bullet, transform.position, Quaternion.identity);
        
    }
    public override void follow()
    {
        if(cooldown > 0)
        {
            base.follow();
        }
        else if(cooldown < 0)
        {
            
        }
    }
    private void Update()
    {
        cooldown += Time.deltaTime;
        if(cooldown > 2)
        {
            cooldown = -1;
        }
        follow();
    }
}
